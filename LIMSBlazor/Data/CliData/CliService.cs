using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class CliService : ICliService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public CliService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> CliInsert(Cli cli)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", cli.Name, DbType.String);
                    parametrs.Add("FullName", cli.FullName, DbType.String);
                    parametrs.Add("PhoneNumber", cli.PhoneNumber, DbType.String);
                    parametrs.Add("Organization", cli.Organization, DbType.String);
                    await conn.ExecuteAsync("spClis_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<Cli>> CliList()
        {
            IEnumerable<Cli> clis;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                clis = await conn.QueryAsync<Cli>("spClis_GetAll", commandType: CommandType.StoredProcedure);
            }
            return clis;
        }


        /// Получите одни данные на основе его идентификатора
        public async Task<Cli> Cli_GetOne(int id)
        {
            Cli cli = new Cli();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                cli = await conn.QueryFirstOrDefaultAsync<Cli>("spClis_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return cli;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> CliUpdate(Cli cli)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", cli.Id, DbType.Int32);
                    parametrs.Add("Name", cli.Name, DbType.String);
                    parametrs.Add("FullName", cli.FullName, DbType.String);
                    parametrs.Add("PhoneNumber", cli.PhoneNumber, DbType.String);
                    parametrs.Add("Organization", cli.Organization, DbType.String);
                    await conn.ExecuteAsync("spClis_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> CliDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spClis_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
