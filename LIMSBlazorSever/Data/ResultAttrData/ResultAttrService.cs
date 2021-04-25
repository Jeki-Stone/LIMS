using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class ResultAttrService : IResultAttrService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public ResultAttrService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> ResultAttrInsert(ResultAttr resultattr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", resultattr.SampleId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", resultattr.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("AttrId", resultattr.AttrId, DbType.Int32);
                    parametrs.Add("Value", resultattr.Value, DbType.String);
                    parametrs.Add("CreateUser", resultattr.CreateUser, DbType.Int32);
                    parametrs.Add("CreateTime", resultattr.CreateTime, DbType.DateTime);
                    await conn.ExecuteAsync("spResultAttrs_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<ResultAttr>> ResultAttrList(int SampleId, int AnalyticalServiceId)
        {
            IEnumerable<ResultAttr> resultattrs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("SampleId", SampleId, DbType.Int32);
                parametrs.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
                resultattrs = await conn.QueryAsync<ResultAttr>("spResultAttrs_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return resultattrs;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<ResultAttr> ResultAttr_GetOne(int UserId, int LabId, int RoleId)
        {
            ResultAttr resultattr = new ResultAttr();
            var parameters = new DynamicParameters();
            parameters.Add("SampleId", resultattr.SampleId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", resultattr.AnalyticalServiceId, DbType.Int32);
            parameters.Add("AttrId", resultattr.AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                resultattr = await conn.QueryFirstOrDefaultAsync<ResultAttr>("spResultAttrs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return resultattr;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> ResultAttrUpdate(ResultAttr resultattr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", resultattr.SampleId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", resultattr.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("AttrId", resultattr.AttrId, DbType.Int32);
                    parametrs.Add("Value", resultattr.Value, DbType.String);
                    parametrs.Add("UpdateUser", resultattr.UpdateUser, DbType.String);
                    parametrs.Add("UpdateTime", resultattr.UpdateTime, DbType.DateTime);
                    await conn.ExecuteAsync("spResultAttrs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> ResultAttrDelete(int SampleId, int AnalyticalServiceId, int AttrId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleId", SampleId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spResultAttrs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
