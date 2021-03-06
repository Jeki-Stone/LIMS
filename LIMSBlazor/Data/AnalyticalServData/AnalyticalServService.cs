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
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public AnalyticalServService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

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
                    // Stored procedure method
                    await conn.ExecuteAsync("spAnalyticalServices_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<AnalyticalServ>> AnalyticalServList()
        {
            IEnumerable<AnalyticalServ> analyticalservs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                analyticalservs = await conn.QueryAsync<AnalyticalServ>("spAnalyticalServices_GetAll", commandType: CommandType.StoredProcedure);
            }
            return analyticalservs;
        }


        // Get one data based on its ID
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

        // Add (create) a data table row (SQL Update)
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

        //Delete Data
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
