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
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public RoleService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> RoleInsert(Role role)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", role.Name, DbType.String);
                    parametrs.Add("Description", role.Description, DbType.String);
                    await conn.ExecuteAsync("spRoles_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<Role>> RoleList()
        {
            IEnumerable<Role> roles;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                roles = await conn.QueryAsync<Role>("spRoles_GetAll", commandType: CommandType.StoredProcedure);
            }
            return roles;
        }

        /// Получите одни данные на основе его идентификатора
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

        /// Обновить строку таблицы данных в БД
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

        /// Удалить строку таблицы данных из БД
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
