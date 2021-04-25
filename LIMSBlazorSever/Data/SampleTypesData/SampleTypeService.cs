using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleTypeService : ISampleTypeService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public SampleTypeService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> SampleTypeInsert(SampleType sampletype)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", sampletype.Name, DbType.String);
                    parametrs.Add("Description", sampletype.Description, DbType.String);
                    await conn.ExecuteAsync("spSampleTypes_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<SampleType>> SampleTypeList()
        {
            IEnumerable<SampleType> sampletypes;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampletypes = await conn.QueryAsync<SampleType>("spSampleTypes_GetAll", commandType: CommandType.StoredProcedure);
            }
            return sampletypes;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<SampleType> SampleType_GetOne(int id)
        {
            SampleType sampletype = new SampleType();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampletype = await conn.QueryFirstOrDefaultAsync<SampleType>("spSampleTypes_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return sampletype;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> SampleTypeUpdate(SampleType sampletype)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", sampletype.Id, DbType.Int32);
                    parametrs.Add("Name", sampletype.Name, DbType.String);
                    parametrs.Add("Description", sampletype.Description, DbType.String);
                    await conn.ExecuteAsync("spSampleTypes_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> SampleTypeDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleTypes_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
