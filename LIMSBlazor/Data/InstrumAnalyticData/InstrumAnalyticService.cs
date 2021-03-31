using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class InstrumAnalyticService : IInstrumAnalyticService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public InstrumAnalyticService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> InstrumAnalyticInsert(InstrumAnalytic instrumanalitic, int InstrumentId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("InstrumentId", InstrumentId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", instrumanalitic.AnalyticalServiceId, DbType.Int32);
                    await conn.ExecuteAsync("spInstrumentAnalyticals_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<InstrumAnalytic>> InstrumAnalyticList()
        {
            IEnumerable<InstrumAnalytic> instrumanalitics;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                instrumanalitics = await conn.QueryAsync<InstrumAnalytic>("spInstrumentAnalyticals_GetAll", commandType: CommandType.StoredProcedure);
            }
            return instrumanalitics;
        }


        /// Получите одни данные на основе его идентификатора
        public async Task<InstrumAnalytic> InstrumAnalytic_GetOne(int InstrumentId, int AnalyticalServiceId)
        {
            InstrumAnalytic instrumanalitic = new InstrumAnalytic();
            var parameters = new DynamicParameters();
            parameters.Add("InstrumentId", InstrumentId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                instrumanalitic = await conn.QueryFirstOrDefaultAsync<InstrumAnalytic>("spInstrumentAnalyticals_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return instrumanalitic;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> InstrumAnalyticUpdate(InstrumAnalytic instrumanalytic)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("InstrumentId", instrumanalytic.InstrumentId, DbType.Int32);
                    parametrs.Add("OldAnalyticalServiceId", instrumanalytic.OldAnalyticalServiceId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", instrumanalytic.AnalyticalServiceId, DbType.Int32);
                    await conn.ExecuteAsync("spInstrumentAnalyticals_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> InstrumAnalyticDelete(int InstrumentId, int AnalyticalServiceId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("InstrumentId", InstrumentId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spInstrumentAnalyticals_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
