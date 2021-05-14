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

        /// Создание класических ролей
        public async Task<bool> AspNetRoleClassic(string code)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var laborantName = code + "--Лаборант";
                var ingenerName = code + "--Инженер";
                var analitikName = code + "--Аналитик";
                var masterName = code + "--Мастер";

                var laborantTrue = await _roleManager.RoleExistsAsync(laborantName);
                var ingenerTrue = await _roleManager.RoleExistsAsync(ingenerName);
                var analitikTrue = await _roleManager.RoleExistsAsync(analitikName);
                var masterTrue = await _roleManager.RoleExistsAsync(masterName);

                // Лаборант
                if (laborantTrue)
                {
                    var laborant = await _roleManager.FindByNameAsync(laborantName);
                    await _roleManager.DeleteAsync(laborant);
                }
                else
                {
                    var laborant = new IdentityRole { Name = (laborantName) };
                    await _roleManager.CreateAsync(laborant);
                }
                // Инженер
                if (ingenerTrue)
                {
                    var ingener = await _roleManager.FindByNameAsync(ingenerName);
                    await _roleManager.DeleteAsync(ingener);
                }
                else
                {
                    var laborant = new IdentityRole { Name = (ingenerName) };
                    await _roleManager.CreateAsync(laborant);
                }
                // Аналитик
                if (analitikTrue)
                {
                    var analitik = await _roleManager.FindByNameAsync(analitikName);
                    await _roleManager.DeleteAsync(analitik);
                }
                else
                {
                    var laborant = new IdentityRole { Name = (analitikName) };
                    await _roleManager.CreateAsync(laborant);
                }
                // Мастер
                if (masterTrue)
                {
                    var master = await _roleManager.FindByNameAsync(masterName);
                    await _roleManager.DeleteAsync(master);
                }
                else
                {
                    var laborant = new IdentityRole { Name = (masterName) };
                    await _roleManager.CreateAsync(laborant);
                }
            }
            return true;
        }
    }
}
