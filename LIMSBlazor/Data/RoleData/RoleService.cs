using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class RoleService : IRoleService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public RoleService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> RoleInsert(Role role)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", role.Name, DbType.String);
                    parametrs.Add("Description", role.Description, DbType.String);
                    // Stored procedure method
                    await conn.ExecuteAsync("spRoles_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<Role>> RoleList()
        {
            IEnumerable<Role> roles;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                roles = await conn.QueryAsync<Role>("spRoles_GetAll", commandType: CommandType.StoredProcedure);
            }
            return roles;
        }


        // Get one data based on its ID
        public async Task<Role> Role_GetOne(int id)
        {
            Role role = new Role();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                role = await conn.QueryFirstOrDefaultAsync<Role>("spRoles_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return role;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> RoleUpdate(Role role)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", role.Id, DbType.Int32);
                    parametrs.Add("Name", role.Name, DbType.String);
                    parametrs.Add("Description", role.Description, DbType.String);
                    await conn.ExecuteAsync("spRoles_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> RoleDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spRoles_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
