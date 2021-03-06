using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleTypeAnalyticalService : ISampleTypeAnalyticalService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public SampleTypeAnalyticalService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> SampleTypeAnalyticalInsert(SampleTypeAnalytical sampletypeanalytical, int SampleTypeId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleTypeId", SampleTypeId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", sampletypeanalytical.AnalyticalServiceId, DbType.Int32);
                    // Stored procedure method
                    await conn.ExecuteAsync("spSampleTypeAnalyticals_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<SampleTypeAnalytical>> SampleTypeAnalyticalList()
        {
            IEnumerable<SampleTypeAnalytical> sampletypeanalyticals;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampletypeanalyticals = await conn.QueryAsync<SampleTypeAnalytical>("spSampleTypeAnalyticals_GetAll", commandType: CommandType.StoredProcedure);
            }
            return sampletypeanalyticals;
        }


        // Get one data based on its ID
        public async Task<SampleTypeAnalytical> SampleTypeAnalytical_GetOne(int SampleTypeId, int AnalyticalServiceId)
        {
            SampleTypeAnalytical sampletypeanalytical = new SampleTypeAnalytical();
            var parameters = new DynamicParameters();
            parameters.Add("SampleTypeId", SampleTypeId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampletypeanalytical = await conn.QueryFirstOrDefaultAsync<SampleTypeAnalytical>("spSampleTypeAnalyticals_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return sampletypeanalytical;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> SampleTypeAnalyticalUpdate(SampleTypeAnalytical sampletypeanalytical)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleTypeId", sampletypeanalytical.SampleTypeId, DbType.Int32);
                    parametrs.Add("OldAnalyticalServiceId", sampletypeanalytical.OldAnalyticalServiceId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", sampletypeanalytical.AnalyticalServiceId, DbType.Int32);
                    await conn.ExecuteAsync("spSampleTypeAnalyticals_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> SampleTypeAnalyticalDelete(int SampleTypeId, int AnalyticalServiceId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleTypeId", SampleTypeId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleTypeAnalyticals_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
