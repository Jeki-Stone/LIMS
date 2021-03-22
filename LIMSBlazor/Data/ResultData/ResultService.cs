using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class ResultService : IResultService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public ResultService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> ResultInsert(Result result)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", result.SampleId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", result.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("ValueNo", result.ValueNo, DbType.Int32);
                    parametrs.Add("Value", result.Value, DbType.Int32);
                    parametrs.Add("IsFinal", result.IsFinal, DbType.Boolean);
                    parametrs.Add("Note", result.Note, DbType.String);
                    parametrs.Add("CreateTime", result.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", result.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", result.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", result.UpdateUser, DbType.String);
                    // Stored procedure method
                    await conn.ExecuteAsync("spResults_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<Result>> ResultList(int sampleId)
        {
            IEnumerable<Result> results;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("SampleId", sampleId, DbType.Int32);
                results = await conn.QueryAsync<Result>("spResults_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return results;
        }


        // Get one data based on its ID
        public async Task<Result> Result_GetOne(int id)
        {
            Result result = new Result();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                result = await conn.QueryFirstOrDefaultAsync<Result>("spResults_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return result;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> ResultUpdate(Result result)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", result.Id, DbType.Int32);
                    parametrs.Add("SampleId", result.SampleId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", result.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("ValueNo", result.ValueNo, DbType.Int32);
                    parametrs.Add("Value", result.Value, DbType.Int32);
                    parametrs.Add("IsFinal", result.IsFinal, DbType.Boolean);
                    parametrs.Add("Note", result.Note, DbType.String);
                    parametrs.Add("CreateTime", result.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", result.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", result.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", result.UpdateUser, DbType.String);
                    await conn.ExecuteAsync("spResults_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> ResultDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spResults_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
