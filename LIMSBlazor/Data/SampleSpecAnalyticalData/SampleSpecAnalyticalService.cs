using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleSpecAnalyticalService : ISampleSpecAnalyticalService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public SampleSpecAnalyticalService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> SampleSpecAnalyticalInsert(SampleSpecAnalytical samplespecanalytical)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleSpecId", samplespecanalytical.SampleSpecId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", samplespecanalytical.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("MinValue", samplespecanalytical.MinValue, DbType.Int64);
                    parametrs.Add("MaxValue", samplespecanalytical.MaxValue, DbType.Int64);
                    // Stored procedure method
                    await conn.ExecuteAsync("spSampleSpecAnalyticals_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<SampleSpecAnalytical>> SampleSpecAnalyticalList()
        {
            IEnumerable<SampleSpecAnalytical> samplespecanalyticals;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                samplespecanalyticals = await conn.QueryAsync<SampleSpecAnalytical>("spSampleSpecAnalyticals_GetAll", commandType: CommandType.StoredProcedure);
            }
            return samplespecanalyticals;
        }


        // Get one data based on its ID
        public async Task<SampleSpecAnalytical> SampleSpecAnalytical_GetOne(int SampleSpecId, int AnalyticalServiceId)
        {
            SampleSpecAnalytical samplespecanalytical = new SampleSpecAnalytical();
            var parameters = new DynamicParameters();
            parameters.Add("SampleSpecId", SampleSpecId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                samplespecanalytical = await conn.QueryFirstOrDefaultAsync<SampleSpecAnalytical>("spSampleSpecAnalyticals_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return samplespecanalytical;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> SampleSpecAnalyticalUpdate(SampleSpecAnalytical samplespecanalytical)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleSpecId", samplespecanalytical.SampleSpecId, DbType.Int32);
                    parametrs.Add("OldSampleSpecId", samplespecanalytical.OldSampleSpecId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", samplespecanalytical.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("OldAnalyticalServiceId", samplespecanalytical.OldAnalyticalServiceId, DbType.Int32);
                    parametrs.Add("MinValue", samplespecanalytical.MinValue, DbType.Int64);
                    parametrs.Add("MaxValue", samplespecanalytical.MaxValue, DbType.Int64);
                    await conn.ExecuteAsync("spSampleSpecAnalyticals_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> SampleSpecAnalyticalDelete(int SampleSpecId, int AnalyticalServiceId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleSpecId", SampleSpecId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleSpecAnalyticals_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
