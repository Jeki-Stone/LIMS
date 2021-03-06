using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class LabService : ILabService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public LabService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> LabInsert(Lab lab)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Code", lab.Code, DbType.String);
                    parametrs.Add("Name", lab.Name, DbType.String);
                    parametrs.Add("LocId", lab.LocId, DbType.Int32);
                    parametrs.Add("Description", lab.Description, DbType.String);
                    // Stored procedure method
                    await conn.ExecuteAsync("spLabs_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<Lab>> LabList()
        {
            IEnumerable<Lab> labs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                labs = await conn.QueryAsync<Lab>("spLabs_GetAll", commandType: CommandType.StoredProcedure);
            }
            return labs;
        }


        // Get one data based on its ID
        public async Task<Lab> Lab_GetOne(int id)
        {
            Lab lab = new Lab();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                lab = await conn.QueryFirstOrDefaultAsync<Lab>("spLabs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return lab;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> LabUpdate(Lab lab)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", lab.Id, DbType.Int32);
                    parametrs.Add("Code", lab.Code, DbType.String);
                    parametrs.Add("Name", lab.Name, DbType.String);
                    parametrs.Add("LocId", lab.LocId, DbType.Int32);
                    parametrs.Add("Description", lab.Description, DbType.String);
                    await conn.ExecuteAsync("spLabs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> LabDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spLabs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
