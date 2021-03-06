using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class UserService : IUserService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public UserService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> UserInsert(User user)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", user.Name, DbType.String);
                    parametrs.Add("FullName", user.FullName, DbType.String);
                    parametrs.Add("PhoneNumber", user.PhoneNumber, DbType.String);
                    parametrs.Add("Password", user.Password, DbType.String);
                    // Stored procedure method
                    await conn.ExecuteAsync("spUsers_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<User>> UserList()
        {
            IEnumerable<User> users;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                users = await conn.QueryAsync<User>("spUsers_GetAll", commandType: CommandType.StoredProcedure);
            }
            return users;
        }


        // Get one data based on its ID
        public async Task<User> User_GetOne(int id)
        {
            User user = new User();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                user = await conn.QueryFirstOrDefaultAsync<User>("spUsers_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return user;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> UserUpdate(User user)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", user.Id, DbType.Int32);
                    parametrs.Add("Name", user.Name, DbType.String);
                    parametrs.Add("FullName", user.FullName, DbType.String);
                    parametrs.Add("PhoneNumber", user.PhoneNumber, DbType.String);
                    parametrs.Add("Password", user.Password, DbType.String);
                    await conn.ExecuteAsync("spUsers_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> UserDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spUsers_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
