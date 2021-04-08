using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class FinalResultService : IFinalResultService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public FinalResultService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> FinalResultInsert(FinalResult finalresult)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", finalresult.SampleId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", finalresult.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("InstrumentId", finalresult.InstrumentId, DbType.Int32);
                    parametrs.Add("ValueNo", finalresult.ValueNo, DbType.String);
                    parametrs.Add("Value", finalresult.Value, DbType.Int32);
                    parametrs.Add("IsFinal", finalresult.IsFinal, DbType.Boolean);
                    parametrs.Add("Note", finalresult.Note, DbType.String);
                    parametrs.Add("CreateTime", finalresult.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", finalresult.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", finalresult.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", finalresult.UpdateUser, DbType.String);
                    await conn.ExecuteAsync("spFinalResults_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все данные соответствующие sampleId из БД
        public async Task<IEnumerable<FinalResult>> FinalResultList(int sampleId)
        {
            IEnumerable<FinalResult> finalresults;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("SampleId", sampleId, DbType.Int32);
                finalresults = await conn.QueryAsync<FinalResult>("spFinalResults_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return finalresults;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<FinalResult> FinalResult_GetOne(int id)
        {
            FinalResult finalresult = new FinalResult();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                finalresult = await conn.QueryFirstOrDefaultAsync<FinalResult>("spFinalResults_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return finalresult;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> FinalResultUpdate(FinalResult finalresult)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", finalresult.Id, DbType.Int32);
                    parametrs.Add("SampleId", finalresult.SampleId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", finalresult.AnalyticalServiceId, DbType.Int32);
                    parametrs.Add("InstrumentId", finalresult.InstrumentId, DbType.Int32);
                    parametrs.Add("ValueNo", finalresult.ValueNo, DbType.String);
                    parametrs.Add("Value", finalresult.Value, DbType.Int32);
                    parametrs.Add("IsFinal", finalresult.IsFinal, DbType.Boolean);
                    parametrs.Add("Note", finalresult.Note, DbType.String);
                    parametrs.Add("CreateTime", finalresult.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", finalresult.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", finalresult.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", finalresult.UpdateUser, DbType.String);
                    await conn.ExecuteAsync("spFinalResults_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> FinalResultDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spFinalResults_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }

        /// Удалить все строки таблицы с данными SampleId и AnalyticalServiceId из БД
        public async Task<bool> FinalResultDeleteAll(int SampleId, int AnalyticalServiceId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleId", SampleId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spFinalResults_DeleteAll", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
