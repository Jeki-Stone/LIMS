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
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public InstrumTypeAnalyticService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> InstrumTypeAnalyticInsert(InstrumTypeAnalytic instrumtypeanalitic, int InstrumentTypeId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("InstrumentTypeId", InstrumentTypeId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", instrumtypeanalitic.AnalyticalServiceId, DbType.Int32);
                    // Stored procedure method
                    await conn.ExecuteAsync("spInstrumentTypeAnalyticals_Insert", parametrs, commandType: CommandType.StoredProcedure);

                    // Raw SQL method.
                    //const string query = @"INSERT INTO Labs(Code, Name, Location, Description) VALUES(@Code, @Name, @Location, @Description)";
                    //await conn.ExecuteAsync(query, new { lab.Code, lab.Name, lab.Location, lab.Description }, commandType: CommandType.Text);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        public async Task<IEnumerable<InstrumTypeAnalytic>> InstrumTypeAnalyticList()
        {
            IEnumerable<InstrumTypeAnalytic> instrumtypeanalitics;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                instrumtypeanalitics = await conn.QueryAsync<InstrumTypeAnalytic>("spInstrumentTypeAnalyticals_GetAll", commandType: CommandType.StoredProcedure);
            }
            return instrumtypeanalitics;
        }


        // Get one data based on its ID
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

        // Add (create) a data table row (SQL Update)
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

        //Delete Data
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
