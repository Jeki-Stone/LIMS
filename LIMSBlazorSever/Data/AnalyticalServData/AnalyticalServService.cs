using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class AnalyticalServService : IAnalyticalServService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public AnalyticalServService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> AnalyticalServInsert(AnalyticalServ analyticalserv)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", analyticalserv.Name, DbType.String);
                    parametrs.Add("CategoryId", analyticalserv.CategoryId, DbType.Int32);
                    parametrs.Add("UnitId", analyticalserv.UnitId, DbType.Int32);
                    parametrs.Add("Description", analyticalserv.Description, DbType.String);
                    await conn.ExecuteAsync("spAnalyticalServices_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<AnalyticalServ>> AnalyticalServList()
        {
            IEnumerable<AnalyticalServ> analyticalservs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                analyticalservs = await conn.QueryAsync<AnalyticalServ>("spAnalyticalServices_GetAll", commandType: CommandType.StoredProcedure);
            }
            return analyticalservs;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<AnalyticalServ> AnalyticalServ_GetOne(int id)
        {
            AnalyticalServ analyticalserv = new AnalyticalServ();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                analyticalserv = await conn.QueryFirstOrDefaultAsync<AnalyticalServ>("spAnalyticalServices_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return analyticalserv;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> AnalyticalServUpdate(AnalyticalServ analyticalserv)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", analyticalserv.Id, DbType.Int32);
                    parametrs.Add("Name", analyticalserv.Name, DbType.String);
                    parametrs.Add("CategoryId", analyticalserv.CategoryId, DbType.Int32);
                    parametrs.Add("UnitId", analyticalserv.UnitId, DbType.Int32);
                    parametrs.Add("Description", analyticalserv.Description, DbType.String);
                    await conn.ExecuteAsync("spAnalyticalServices_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> AnalyticalServDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spAnalyticalServices_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
