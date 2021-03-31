using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class AnalyticalServiceAttrService : IAnalyticalServiceAttrService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public AnalyticalServiceAttrService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> AnalyticalServiceAttrInsert(AnalyticalServiceAttr analyticalServiceAttr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("AnalyticalServiceId", analyticalServiceAttr.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("AttrId", analyticalServiceAttr.AttrId, DbType.Int32);
                    await conn.ExecuteAsync("spAnalyticalServiceAttrs_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<AnalyticalServiceAttr>> AnalyticalServiceAttrList(int AnalyticalServiceId)
        {
            IEnumerable<AnalyticalServiceAttr> analyticalServiceAttrs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
                analyticalServiceAttrs = await conn.QueryAsync<AnalyticalServiceAttr>("spAnalyticalServiceAttrs_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return analyticalServiceAttrs;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<AnalyticalServiceAttr> AnalyticalServiceAttr_GetOne(int AnalyticalServiceId, int AttrId)
        {
            AnalyticalServiceAttr analyticalServiceAttr = new AnalyticalServiceAttr();
            var parameters = new DynamicParameters();
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                analyticalServiceAttr = await conn.QueryFirstOrDefaultAsync<AnalyticalServiceAttr>("spAnalyticalServiceAttrs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return analyticalServiceAttr;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> AnalyticalServiceAttrUpdate(AnalyticalServiceAttr analyticalServiceAttr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("AnalyticalServiceId", analyticalServiceAttr.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("OldAttrId", analyticalServiceAttr.OldAttrId, DbType.Int32);
                    parametrs.Add("AttrId", analyticalServiceAttr.AttrId, DbType.Int32);
                    await conn.ExecuteAsync("spAnalyticalServiceAttrs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> AnalyticalServiceAttrDelete(int AnalyticalServiceId, int AttrId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spAnalyticalServiceAttrs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
