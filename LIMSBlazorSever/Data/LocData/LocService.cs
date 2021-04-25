using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class LocService : ILocService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public LocService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> LocInsert(Loc loc)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", loc.Name, DbType.String);
                    parametrs.Add("Description", loc.Description, DbType.String);
                    await conn.ExecuteAsync("spLocs_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<Loc>> LocList()
        {
            IEnumerable<Loc> locs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                locs = await conn.QueryAsync<Loc>("spLocs_GetAll", commandType: CommandType.StoredProcedure);
            }
            return locs;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<Loc> Loc_GetOne(int id)
        {
            Loc loc = new Loc();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                loc = await conn.QueryFirstOrDefaultAsync<Loc>("spLocs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return loc;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> LocUpdate(Loc loc)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", loc.Id, DbType.Int32);
                    parametrs.Add("Name", loc.Name, DbType.String);
                    parametrs.Add("Description", loc.Description, DbType.String);
                    await conn.ExecuteAsync("spLocs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> LocDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spLocs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
