using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleAttrService : ISampleAttrService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public SampleAttrService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> SampleAttrInsert(SampleAttr sampleattr, int SampleId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", SampleId, DbType.Int32);
                    parametrs.Add("AttrId", sampleattr.AttrId, DbType.Int32);
                    parametrs.Add("Value", sampleattr.Value, DbType.String);
                    parametrs.Add("CreateTime", sampleattr.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", sampleattr.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", sampleattr.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", sampleattr.UpdateUser, DbType.String);
                    await conn.ExecuteAsync("spSampleAttrs_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<SampleAttr>> SampleAttrList(int SampleId)
        {
            IEnumerable<SampleAttr> sampleattrs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("SampleId", SampleId, DbType.Int32);
                sampleattrs = await conn.QueryAsync<SampleAttr>("spSampleAttrs_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return sampleattrs;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<SampleAttr> SampleAttr_GetOne(int SampleId, int AttrId)
        {
            SampleAttr sampleattr = new SampleAttr();
            var parameters = new DynamicParameters();
            parameters.Add("SampleId", SampleId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampleattr = await conn.QueryFirstOrDefaultAsync<SampleAttr>("spSampleAttrs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return sampleattr;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> SampleAttrUpdate(SampleAttr sampleattr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", sampleattr.SampleId, DbType.Int32);
                    parametrs.Add("AttrId", sampleattr.AttrId, DbType.Int32);
                    parametrs.Add("OldAttrId", sampleattr.OldAttrId, DbType.Int32);
                    parametrs.Add("Value", sampleattr.Value, DbType.String);
                    parametrs.Add("CreateTime", sampleattr.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", sampleattr.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", sampleattr.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", sampleattr.UpdateUser, DbType.String);
                    await conn.ExecuteAsync("spSampleAttrs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> SampleAttrDelete(int SampleId, int AttrId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleId", SampleId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleAttrs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
