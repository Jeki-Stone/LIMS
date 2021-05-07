using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LIMSBlazor.Data
{
    public class AspNetRoleService : IAspNetRoleService
    {
        RoleManager<IdentityRole> _roleManager;

        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public AspNetRoleService(SqlConnectionConfiguration configuration, RoleManager<IdentityRole> manager)
        {
            _configuration = configuration;
            _roleManager = manager;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> AspNetRoleInsert(IdentityRole _identityRole)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    await _roleManager.CreateAsync(_identityRole);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<List<IdentityRole>> AspNetRoleList()
        {
            List<IdentityRole> roleList;
            await using (var conn = new SqlConnection(_configuration.Value))
            {
                roleList = _roleManager.Roles.ToList();
            }
            return roleList;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<IdentityRole> AspNetRole_GetOne(string id)
        {
            IdentityRole role;
            await using (var conn = new SqlConnection(_configuration.Value))
            {
                role = await _roleManager.FindByIdAsync(id);
            }
            return role;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> AspNetRoleUpdate(IdentityRole _identityRole)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    await _roleManager.UpdateAsync(_identityRole);
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
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await _roleManager.DeleteAsync(await _roleManager.FindByIdAsync(id));
            }
            return true;
        }
    }
}
