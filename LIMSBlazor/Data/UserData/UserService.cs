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
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public UserService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
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
                    await conn.ExecuteAsync("spUsers_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<User>> UserList()
        {
            IEnumerable<User> users;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                users = await conn.QueryAsync<User>("spUsers_GetAll", commandType: CommandType.StoredProcedure);
            }
            return users;
        }

        /// Получите одни данные на основе его идентификатора
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

        /// Обновить строку таблицы данных в БД
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

        /// Удалить строку таблицы данных из БД
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

        /// Получите данные на основе его имени и пароля
        public async Task<User> User_GetLogin(string Name, string Password)
        {
            User user = new User();
            var parameters = new DynamicParameters();
            parameters.Add("Name", Name, DbType.Int32);
            parameters.Add("Password", Password, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                user = await conn.QueryFirstOrDefaultAsync<User>("spUsers_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return user;
        }
    }
}
