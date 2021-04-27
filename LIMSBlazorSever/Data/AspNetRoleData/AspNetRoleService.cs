using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class AspNetRoleService : IAspNetRoleService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public AspNetRoleService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> AspNetRoleInsert(AspNetRole aspNetRole)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", aspNetRole.Name, DbType.String);
                    parametrs.Add("LabId", aspNetRole.LabId, DbType.Int32);
                    await conn.ExecuteAsync("spAspNetRoles_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<AspNetRole>> AspNetRoleList()
        {
            IEnumerable<AspNetRole> aspNetRoles;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                aspNetRoles = await conn.QueryAsync<AspNetRole>("spAspNetRoles_GetAll", commandType: CommandType.StoredProcedure);
            }
            return aspNetRoles;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<AspNetRole> AspNetRole_GetOne(string id)
        {
            AspNetRole aspNetRole = new AspNetRole();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.String);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                aspNetRole = await conn.QueryFirstOrDefaultAsync<AspNetRole>("spAspNetRoles_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return aspNetRole;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> AspNetRoleUpdate(AspNetRole aspNetRole)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", aspNetRole.Id, DbType.String);
                    parametrs.Add("Name", aspNetRole.Name, DbType.String);
                    parametrs.Add("LabId", aspNetRole.LabId, DbType.Int32);
                    await conn.ExecuteAsync("spAspNetRoles_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> AspNetRoleDelete(string id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spAspNetRoles_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
