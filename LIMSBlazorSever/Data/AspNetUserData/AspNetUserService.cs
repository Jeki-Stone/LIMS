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
    public class AspNetUserService : IAspNetUserService
    {
        UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public AspNetUserService(SqlConnectionConfiguration configuration, UserManager<IdentityUser> manager, SignInManager<IdentityUser> signInManager)
        {
            _configuration = configuration;
            _userManager = manager;
            _signInManager = signInManager;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> AspNetUserInsert(IdentityUser user, string password)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var result = await _userManager.CreateAsync(user, password);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, true);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<List<IdentityUser>> AspNetUserList()
        {
            List<IdentityUser> userList;
            await using (var conn = new SqlConnection(_configuration.Value))
            {
                userList = _userManager.Users.ToList();
            }
            return userList;
        }

        public async Task<List<IdentityUser>> AspNetUserClientList()
        {
            List<IdentityUser> userClientList = new List<IdentityUser>();
            await using (var conn = new SqlConnection(_configuration.Value))
            {
                List<IdentityUser> userList;
                userList = _userManager.Users.ToList();
                foreach (var item in userList)
                {
                    var status = await _userManager.IsInRoleAsync(item, "Client");
                    if (status)
                        userClientList.Add(item);
                }
            }
            return userClientList;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<IdentityUser> AspNetUser_GetOne(string id)
        {
            IdentityUser user;
            await using (var conn = new SqlConnection(_configuration.Value))
            {
                user = await _userManager.FindByIdAsync(id);
            }
            return user;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> AspNetUserUpdate(IdentityUser _identityUser)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    await _userManager.UpdateAsync(_identityUser);
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
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var user = await _userManager.FindByIdAsync(id);
                await _userManager.DeleteAsync(user);
            }
            return true;
        }
    }
}
