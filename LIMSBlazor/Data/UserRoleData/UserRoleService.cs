using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class UserRoleService : IUserRoleService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public UserRoleService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> UserRoleInsert(UserRole userrole, int UserId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("UserId", UserId, DbType.Int32);
                    parametrs.Add("LabId", userrole.LabId, DbType.Int32);
                    parametrs.Add("RoleId", userrole.RoleId, DbType.Int32);
                    await conn.ExecuteAsync("spUserRoles_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<UserRole>> UserRoleList(int UserId)
        {
            IEnumerable<UserRole> userroles;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("UserId", UserId, DbType.Int32);
                userroles = await conn.QueryAsync<UserRole>("spUserRoles_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return userroles;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<UserRole> UserRole_GetOne(int UserId, int LabId, int RoleId)
        {
            UserRole userrole = new UserRole();
            var parameters = new DynamicParameters();
            parameters.Add("UserId", UserId, DbType.Int32);
            parameters.Add("LabId", LabId, DbType.Int32);
            parameters.Add("RoleId", RoleId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                userrole = await conn.QueryFirstOrDefaultAsync<UserRole>("spUserRoles_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return userrole;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> UserRoleUpdate(UserRole userrole)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("UserId", userrole.UserId, DbType.Int32);
                    parametrs.Add("OldLabId", userrole.OldLabId, DbType.Int32);
                    parametrs.Add("OldRoleId", userrole.OldRoleId, DbType.Int32);
                    parametrs.Add("LabId", userrole.LabId, DbType.Int32);
                    parametrs.Add("RoleId", userrole.RoleId, DbType.Int32);
                    await conn.ExecuteAsync("spUserRoles_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> UserRoleDelete(int UserId, int LabId, int RoleId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("UserId", UserId, DbType.Int32);
            parameters.Add("LabId", LabId, DbType.Int32);
            parameters.Add("RoleId", RoleId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spUserRoles_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
