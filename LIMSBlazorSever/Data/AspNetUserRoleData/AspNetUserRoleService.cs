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
    public class AspNetUserRoleService : IAspNetUserRoleService
    {
        UserManager<IdentityUser> _userManager;
        RoleManager<IdentityRole> _roleManager;

        ILabService LabService;

        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public AspNetUserRoleService(SqlConnectionConfiguration configuration, UserManager<IdentityUser> manager, RoleManager<IdentityRole> manager1, ILabService LabService1)
        {
            _configuration = configuration;
            _userManager = manager;
            _roleManager = manager1;
            LabService = LabService1;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> UserRoleInsert(string UserId, string RoleName)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    IdentityUser user = await _userManager.FindByIdAsync(UserId);
                    await _userManager.AddToRoleAsync(user, RoleName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IList<string>> UserRoleList(string UserId)
        {
            IList<string> userroles = new List<string>();
            using (var conn = new SqlConnection(_configuration.Value))
            {
                IdentityUser user = await _userManager.FindByIdAsync(UserId);
                userroles = await _userManager.GetRolesAsync(user);
            }
            return userroles;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> UserRoleDelete(string UserId, string userRoleName)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    IdentityUser user = await _userManager.FindByIdAsync(UserId);
                    await _userManager.RemoveFromRoleAsync(user, userRoleName);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// <summary>
        /// Проверяет есть ли у пользователя такая роль
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public async Task<bool> UserHaveRole(string UserId, string roleName)
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                IdentityUser user = await _userManager.FindByIdAsync(UserId);
                return await _userManager.IsInRoleAsync(user, roleName);
            }
        }

        /// <summary>
        /// Список лабораторий на основе доступных ролей.
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public async Task<List<Lab>> UserByNameLab(string UserName)
        {
            List<Lab> labs = new List<Lab>();
            using (var conn = new SqlConnection(_configuration.Value))
            {
                IdentityUser user = await _userManager.FindByNameAsync(UserName);
                if (!await _userManager.IsInRoleAsync(user, "ADMIN") && !await _userManager.IsInRoleAsync(user, "Client"))
                {
                    IList<string> roles = await _userManager.GetRolesAsync(user);
                    if (roles != null)
                        foreach (var item in roles)
                        {
                            string[] sub = item.Split("--");
                            var lab = await LabService.LabByCod(Convert.ToString(sub[0]));
                            if (!labs.Any(e => e.Name == lab.Name))
                                labs.Add(lab);
                        }
                }
                else
                {
                    var labList = await LabService.LabList();
                    foreach (var item in labList)
                        labs.Add(item);
                }
            }
            return labs;
        }
    }
}
