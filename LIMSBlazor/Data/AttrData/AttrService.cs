using Dapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class AttrService : IAttrService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public AttrService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> AttrInsert(Attr attr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", attr.Name, DbType.String);
                    parametrs.Add("Description", attr.Description, DbType.String);
                    parametrs.Add("Type", attr.Type, DbType.String);
                    parametrs.Add("Options", attr.Options, DbType.String);
                    await conn.ExecuteAsync("spAttrs_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<Attr>> AttrList()
        {
            IEnumerable<Attr> attrs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                attrs = await conn.QueryAsync<Attr>("spAttrs_GetAll", commandType: CommandType.StoredProcedure);
            }
            return attrs;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<Attr> Attr_GetOne(int id)
        {
            Attr attr = new Attr();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                attr = await conn.QueryFirstOrDefaultAsync<Attr>("spAttrs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return attr;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<IEnumerable<AttrOpton>> Attr_GetOptions(string sql)
        {
            IEnumerable<AttrOpton> model;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                model = await conn.QueryAsync<AttrOpton>(sql, null, commandType: CommandType.Text);
            }
            return model;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> AttrUpdate(Attr attr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", attr.Id, DbType.Int32);
                    parametrs.Add("Name", attr.Name, DbType.String);
                    parametrs.Add("Description", attr.Description, DbType.String);
                    parametrs.Add("Type", attr.Type, DbType.String);
                    parametrs.Add("Options", attr.Options, DbType.String);
                    await conn.ExecuteAsync("spAttrs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> AttrDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spAttrs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
