using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleSpecService : ISampleSpecService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public SampleSpecService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> SampleSpecInsert(SampleSpec samplespec)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", samplespec.Name, DbType.String);
                    parametrs.Add("Description", samplespec.Description, DbType.String);
                    parametrs.Add("Version", samplespec.Version, DbType.String);
                    // Stored procedure method
                    await conn.ExecuteAsync("spSampleSpecs_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<SampleSpec>> SampleSpecList()
        {
            IEnumerable<SampleSpec> samplespecs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                samplespecs = await conn.QueryAsync<SampleSpec>("spSampleSpecs_GetAll", commandType: CommandType.StoredProcedure);
            }
            return samplespecs;
        }


        // Get one data based on its ID
        public async Task<SampleSpec> SampleSpec_GetOne(int id)
        {
            SampleSpec samplespec = new SampleSpec();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                samplespec = await conn.QueryFirstOrDefaultAsync<SampleSpec>("spSampleSpecs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return samplespec;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> SampleSpecUpdate(SampleSpec samplespec)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", samplespec.Id, DbType.Int32);
                    parametrs.Add("Name", samplespec.Name, DbType.String);
                    parametrs.Add("Description", samplespec.Description, DbType.String);
                    parametrs.Add("Version", samplespec.Version, DbType.String);
                    await conn.ExecuteAsync("spSampleSpecs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> SampleSpecDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleSpecs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
