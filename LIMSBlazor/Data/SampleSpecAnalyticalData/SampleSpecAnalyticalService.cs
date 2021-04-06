using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleSpecAnalyticalService : ISampleSpecAnalyticalService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public SampleSpecAnalyticalService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> SampleSpecAnalyticalInsert(SampleSpecAnalytical samplespecanalytical)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleSpecId", samplespecanalytical.SampleSpecId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", samplespecanalytical.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("MinValue", samplespecanalytical.MinValue, DbType.Int64);
                    parametrs.Add("MaxValue", samplespecanalytical.MaxValue, DbType.Int64);
                    await conn.ExecuteAsync("spSampleSpecAnalyticals_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<SampleSpecAnalytical>> SampleSpecAnalyticalList(int SampleSpecId)
        {
            IEnumerable<SampleSpecAnalytical> samplespecanalyticals;
            var parameters = new DynamicParameters();
            parameters.Add("SampleSpecId", SampleSpecId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                samplespecanalyticals = await conn.QueryAsync<SampleSpecAnalytical>("spSampleSpecAnalyticals_GetAll", parameters, commandType: CommandType.StoredProcedure);
            }
            return samplespecanalyticals;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<SampleSpecAnalytical> SampleSpecAnalytical_GetOne(int SampleSpecId, int AnalyticalServiceId)
        {
            SampleSpecAnalytical samplespecanalytical = new SampleSpecAnalytical();
            var parameters = new DynamicParameters();
            parameters.Add("SampleSpecId", SampleSpecId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                samplespecanalytical = await conn.QueryFirstOrDefaultAsync<SampleSpecAnalytical>("spSampleSpecAnalyticals_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return samplespecanalytical;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> SampleSpecAnalyticalUpdate(SampleSpecAnalytical samplespecanalytical)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleSpecId", samplespecanalytical.SampleSpecId, DbType.Int32);
                    parametrs.Add("OldSampleSpecId", samplespecanalytical.OldSampleSpecId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", samplespecanalytical.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("OldAnalyticalServiceId", samplespecanalytical.OldAnalyticalServiceId, DbType.Int32);
                    parametrs.Add("MinValue", samplespecanalytical.MinValue, DbType.Int64);
                    parametrs.Add("MaxValue", samplespecanalytical.MaxValue, DbType.Int64);
                    await conn.ExecuteAsync("spSampleSpecAnalyticals_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> SampleSpecAnalyticalDelete(int SampleSpecId, int AnalyticalServiceId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleSpecId", SampleSpecId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleSpecAnalyticals_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
