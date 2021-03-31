using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class InstrumTypeAnalyticService : IInstrumTypeAnalyticService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public InstrumTypeAnalyticService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> InstrumTypeAnalyticInsert(InstrumTypeAnalytic instrumtypeanalitic, int InstrumentTypeId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("InstrumentTypeId", InstrumentTypeId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", instrumtypeanalitic.AnalyticalServiceId, DbType.Int32);
                    await conn.ExecuteAsync("spInstrumentTypeAnalyticals_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из соответствующие InstrumentTypeId БД
        public async Task<IEnumerable<InstrumTypeAnalytic>> InstrumTypeAnalyticList(int InstrumentTypeId)
        {
            IEnumerable<InstrumTypeAnalytic> instrumtypeanalitics;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("InstrumentTypeId", InstrumentTypeId, DbType.Int32);
                instrumtypeanalitics = await conn.QueryAsync<InstrumTypeAnalytic>("spInstrumentTypeAnalyticals_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return instrumtypeanalitics;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<InstrumTypeAnalytic> InstrumTypeAnalytic_GetOne(int InstrumentTypeId, int AnalyticalServiceId)
        {
            InstrumTypeAnalytic instrumtypeanalitic = new InstrumTypeAnalytic();
            var parameters = new DynamicParameters();
            parameters.Add("InstrumentTypeId", InstrumentTypeId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                instrumtypeanalitic = await conn.QueryFirstOrDefaultAsync<InstrumTypeAnalytic>("spInstrumentTypeAnalyticals_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return instrumtypeanalitic;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> InstrumTypeAnalyticUpdate(InstrumTypeAnalytic instrumtypeanalytic)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("InstrumentTypeId", instrumtypeanalytic.InstrumentTypeId, DbType.Int32);
                    parametrs.Add("OldAnalyticalServiceId", instrumtypeanalytic.OldAnalyticalServiceId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", instrumtypeanalytic.AnalyticalServiceId, DbType.Int32);
                    await conn.ExecuteAsync("spInstrumentTypeAnalyticals_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> InstrumTypeAnalyticDelete(int InstrumentTypeId, int AnalyticalServiceId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("InstrumentTypeId", InstrumentTypeId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spInstrumentTypeAnalyticals_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
