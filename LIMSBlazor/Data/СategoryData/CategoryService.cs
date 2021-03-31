using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class CategoryService : ICategoryService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public CategoryService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> CategoryInsert(Category сategory)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", сategory.Name, DbType.String);
                    parametrs.Add("Description", сategory.Description, DbType.String);
                    await conn.ExecuteAsync("spCategories_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<Category>> CategoryList()
        {
            IEnumerable<Category> categories;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                categories = await conn.QueryAsync<Category>("spCategories_GetAll", commandType: CommandType.StoredProcedure);
            }
            return categories;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<Category> Category_GetOne(int id)
        {
            Category categories = new Category();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                categories = await conn.QueryFirstOrDefaultAsync<Category>("spCategories_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return categories;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> CategoryUpdate(Category сategory)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", сategory.Id, DbType.Int32);
                    parametrs.Add("Name", сategory.Name, DbType.String);
                    parametrs.Add("Description", сategory.Description, DbType.String);
                    await conn.ExecuteAsync("spCategories_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> CategoryDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spCategories_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
