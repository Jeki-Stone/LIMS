using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleTypeAttrService : ISampleTypeAttrService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public SampleTypeAttrService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> SampleTypeAttrInsert(SampleTypeAttr sampletypeattr, int SampleTypeId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleTypeId", SampleTypeId, DbType.Int32);
                    parametrs.Add("AttrId", sampletypeattr.AttrId, DbType.Int32);
                    await conn.ExecuteAsync("spSampleTypeAttrs_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<SampleTypeAttr>> SampleTypeAttrList(int SampleTypeId)
        {
            IEnumerable<SampleTypeAttr> sampletypeattrs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("SampleTypeId", SampleTypeId, DbType.Int32);
                sampletypeattrs = await conn.QueryAsync<SampleTypeAttr>("spSampleTypeAttrs_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return sampletypeattrs;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<SampleTypeAttr> SampleTypeAttr_GetOne(int SampleTypeId, int AttrId)
        {
            SampleTypeAttr sampletypeattr = new SampleTypeAttr();
            var parameters = new DynamicParameters();
            parameters.Add("SampleTypeId", SampleTypeId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampletypeattr = await conn.QueryFirstOrDefaultAsync<SampleTypeAttr>("spSampleTypeAttrs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return sampletypeattr;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> SampleTypeAttrUpdate(SampleTypeAttr sampletypeattr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleTypeId", sampletypeattr.SampleTypeId, DbType.Int32);
                    parametrs.Add("OldAttrId", sampletypeattr.OldAttrId, DbType.Int32);
                    parametrs.Add("AttrId", sampletypeattr.AttrId, DbType.Int32);
                    await conn.ExecuteAsync("spSampleTypeAttrs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> SampleTypeAttrDelete(int SampleTypeId, int AttrId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleTypeId", SampleTypeId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleTypeAttrs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
