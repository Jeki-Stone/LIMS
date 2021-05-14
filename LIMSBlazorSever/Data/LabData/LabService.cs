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
        private readonly IAspNetRoleService _AspNetRoleService;
        public LabService(SqlConnectionConfiguration configuration, IAspNetRoleService AspNetRoleService)
        {
            _configuration = configuration;
            _AspNetRoleService = AspNetRoleService;
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
                    // Добавление класических ролей
                    await _AspNetRoleService.AspNetRoleClassic(lab.Code);
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
        public async Task<bool> LabDelete(int id, string code)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spLabs_Delete", parameters, commandType: CommandType.StoredProcedure);
                // Удаление класических ролей
                await _AspNetRoleService.AspNetRoleClassic(code);
            }
            return true;
        }

        /// Запросить данные из БД по коду лабаротории
        public async Task<Lab>LabByCod(string Cod)
        {
            Lab lab = new Lab();
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("Cod", Cod, DbType.String);
                lab = await conn.QueryFirstOrDefaultAsync<Lab>("spLabs_GetAllByCod", parametrs, commandType: CommandType.StoredProcedure);
            }
            return lab;
        }
    }
}
