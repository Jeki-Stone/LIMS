using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class LocService : ILocService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public LocService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> LocInsert(Loc loc)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", loc.Name, DbType.String);
                    parametrs.Add("Description", loc.Description, DbType.String);
                    // Stored procedure method
                    await conn.ExecuteAsync("spLocs_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<Loc>> LocList()
        {
            IEnumerable<Loc> locs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                locs = await conn.QueryAsync<Loc>("spLocs_GetAll", commandType: CommandType.StoredProcedure);
            }
            return locs;
        }


        // Get one data based on its ID
        public async Task<Loc> Loc_GetOne(int id)
        {
            Loc loc = new Loc();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                loc = await conn.QueryFirstOrDefaultAsync<Loc>("spLocs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return loc;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> LocUpdate(Loc loc)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", loc.Id, DbType.Int32);
                    parametrs.Add("Name", loc.Name, DbType.String);
                    parametrs.Add("Description", loc.Description, DbType.String);
                    await conn.ExecuteAsync("spLocs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> LocDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spLocs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
