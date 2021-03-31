using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class LabService : ILabService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public LabService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> LabInsert(Lab lab)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Code", lab.Code, DbType.String);
                    parametrs.Add("Name", lab.Name, DbType.String);
                    parametrs.Add("LocId", lab.LocId, DbType.Int32);
                    parametrs.Add("Description", lab.Description, DbType.String);
                    await conn.ExecuteAsync("spLabs_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<Lab>> LabList()
        {
            IEnumerable<Lab> labs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                labs = await conn.QueryAsync<Lab>("spLabs_GetAll", commandType: CommandType.StoredProcedure);
            }
            return labs;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<Lab> Lab_GetOne(int id)
        {
            Lab lab = new Lab();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                lab = await conn.QueryFirstOrDefaultAsync<Lab>("spLabs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return lab;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> LabUpdate(Lab lab)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", lab.Id, DbType.Int32);
                    parametrs.Add("Code", lab.Code, DbType.String);
                    parametrs.Add("Name", lab.Name, DbType.String);
                    parametrs.Add("LocId", lab.LocId, DbType.Int32);
                    parametrs.Add("Description", lab.Description, DbType.String);
                    await conn.ExecuteAsync("spLabs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> LabDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spLabs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
