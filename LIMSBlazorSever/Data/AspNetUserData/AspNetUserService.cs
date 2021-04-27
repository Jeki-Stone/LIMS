using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class AspNetUserService : IAspNetUserService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public AspNetUserService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<AspNetUser>> AspNetUserList()
        {
            IEnumerable<AspNetUser> aspNetUsers;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                aspNetUsers = await conn.QueryAsync<AspNetUser>("spAspNetUsers_GetAll", commandType: CommandType.StoredProcedure);
            }
            return aspNetUsers;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<AspNetUser> AspNetUser_GetOne(string id)
        {
            AspNetUser aspNetUser = new AspNetUser();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.String);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                aspNetUser = await conn.QueryFirstOrDefaultAsync<AspNetUser>("spAspNetUsers_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return aspNetUser;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> AspNetUserUpdate(AspNetUser aspNetUser)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", aspNetUser.Id, DbType.String);
                    parametrs.Add("UserName", aspNetUser.UserName, DbType.String);
                    parametrs.Add("Email", aspNetUser.Email, DbType.String);
                    parametrs.Add("PhoneNumber", aspNetUser.PhoneNumber, DbType.String);
                    await conn.ExecuteAsync("spAspNetUsers_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> AspNetUserDelete(string id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.String);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spAspNetUsers_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
