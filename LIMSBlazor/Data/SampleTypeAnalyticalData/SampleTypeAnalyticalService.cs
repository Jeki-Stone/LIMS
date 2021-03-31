using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleTypeAnalyticalService : ISampleTypeAnalyticalService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public SampleTypeAnalyticalService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> SampleTypeAnalyticalInsert(SampleTypeAnalytical sampletypeanalytical, int SampleTypeId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleTypeId", SampleTypeId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", sampletypeanalytical.AnalyticalServiceId, DbType.Int32);
                    await conn.ExecuteAsync("spSampleTypeAnalyticals_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<SampleTypeAnalytical>> SampleTypeAnalyticalList(int SampleTypeId)
        {
            IEnumerable<SampleTypeAnalytical> sampletypeanalyticals;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("SampleTypeId", SampleTypeId, DbType.Int32);
                sampletypeanalyticals = await conn.QueryAsync<SampleTypeAnalytical>("spSampleTypeAnalyticals_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return sampletypeanalyticals;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<SampleTypeAnalytical> SampleTypeAnalytical_GetOne(int SampleTypeId, int AnalyticalServiceId)
        {
            SampleTypeAnalytical sampletypeanalytical = new SampleTypeAnalytical();
            var parameters = new DynamicParameters();
            parameters.Add("SampleTypeId", SampleTypeId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampletypeanalytical = await conn.QueryFirstOrDefaultAsync<SampleTypeAnalytical>("spSampleTypeAnalyticals_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return sampletypeanalytical;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> SampleTypeAnalyticalUpdate(SampleTypeAnalytical sampletypeanalytical)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleTypeId", sampletypeanalytical.SampleTypeId, DbType.Int32);
                    parametrs.Add("OldAnalyticalServiceId", sampletypeanalytical.OldAnalyticalServiceId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", sampletypeanalytical.AnalyticalServiceId, DbType.Int32);
                    await conn.ExecuteAsync("spSampleTypeAnalyticals_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> SampleTypeAnalyticalDelete(int SampleTypeId, int AnalyticalServiceId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleTypeId", SampleTypeId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleTypeAnalyticals_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
