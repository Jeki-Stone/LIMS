using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class FinalResultService : IFinalResultService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public FinalResultService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> FinalResultInsert(FinalResult finalresult)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", finalresult.SampleId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", finalresult.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("ValueNo", finalresult.ValueNo, DbType.String);
                    parametrs.Add("Value", finalresult.Value, DbType.Int32);
                    parametrs.Add("IsFinal", finalresult.IsFinal, DbType.Boolean);
                    parametrs.Add("Note", finalresult.Note, DbType.String);
                    parametrs.Add("CreateTime", finalresult.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", finalresult.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", finalresult.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", finalresult.UpdateUser, DbType.String);
                    // Stored procedure method
                    await conn.ExecuteAsync("spFinalResults_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<FinalResult>> FinalResultList(int sampleId)
        {
            IEnumerable<FinalResult> finalresults;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("SampleId", sampleId, DbType.Int32);
                finalresults = await conn.QueryAsync<FinalResult>("spFinalResults_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return finalresults;
        }


        // Get one data based on its ID
        public async Task<FinalResult> FinalResult_GetOne(int id)
        {
            FinalResult finalresult = new FinalResult();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                finalresult = await conn.QueryFirstOrDefaultAsync<FinalResult>("spFinalResults_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return finalresult;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> FinalResultUpdate(FinalResult finalresult)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", finalresult.Id, DbType.Int32);
                    parametrs.Add("SampleId", finalresult.SampleId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", finalresult.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("ValueNo", finalresult.ValueNo, DbType.String);
                    parametrs.Add("Value", finalresult.Value, DbType.Int32);
                    parametrs.Add("IsFinal", finalresult.IsFinal, DbType.Boolean);
                    parametrs.Add("Note", finalresult.Note, DbType.String);
                    parametrs.Add("CreateTime", finalresult.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", finalresult.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", finalresult.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", finalresult.UpdateUser, DbType.String);
                    await conn.ExecuteAsync("spFinalResults_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> FinalResultDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spFinalResults_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
