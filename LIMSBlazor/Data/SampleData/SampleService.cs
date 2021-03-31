using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleService : ISampleService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public SampleService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<Sample> SampleInsert(Sample sample)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("RecieveTime", sample.RecieveTime, DbType.DateTime);
                    parametrs.Add("TestTime", sample.TestTime, DbType.DateTime);
                    parametrs.Add("ClientId", sample.ClientId, DbType.Int32);
                    parametrs.Add("SampleTypeId", sample.SampleTypeId, DbType.Int32);
                    parametrs.Add("NumSamples", sample.NumSamples, DbType.Int32);
                    parametrs.Add("Status", sample.Status, DbType.Int32);
                    parametrs.Add("IsFinal", sample.IsFinal, DbType.Boolean);
                    parametrs.Add("Note", sample.Note, DbType.String);
                    parametrs.Add("LocationId", sample.LocationId, DbType.Int32);
                    parametrs.Add("LastEditComment", sample.LastEditComment, DbType.String);
                    parametrs.Add("CreateTime", sample.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", sample.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", sample.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", sample.UpdateUser, DbType.String);
                    parametrs.Add("FinalizeUser", sample.FinalizeUser, DbType.String);
                    parametrs.Add("FinalizeTime", sample.FinalizeTime, DbType.DateTime);
                    parametrs.Add("Id", sample.Id, DbType.Int32, ParameterDirection.Output);
                    await conn.ExecuteAsync("spSamples_Insert", parametrs, commandType: CommandType.StoredProcedure);
                    var Id = parametrs.Get<int>("Id");
                    return await Sample_GetOne(Id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<Sample>> SampleList()
        {
            IEnumerable<Sample> samples;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                samples = await conn.QueryAsync<Sample>("spSamples_GetAll", commandType: CommandType.StoredProcedure);
            }
            return samples;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<Sample> Sample_GetOne(int id)
        {
            Sample sample = new Sample();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sample = await conn.QueryFirstOrDefaultAsync<Sample>("spSamples_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return sample;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> SampleUpdate(Sample sample)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", sample.Id, DbType.Int32);
                    parametrs.Add("RecieveTime", sample.RecieveTime, DbType.DateTime);
                    parametrs.Add("TestTime", sample.TestTime, DbType.DateTime);
                    parametrs.Add("ClientId", sample.ClientId, DbType.Int32);
                    parametrs.Add("SampleTypeId", sample.SampleTypeId, DbType.Int32);
                    parametrs.Add("NumSamples", sample.NumSamples, DbType.Int32);
                    parametrs.Add("Status", sample.Status, DbType.Int32);
                    parametrs.Add("IsFinal", sample.IsFinal, DbType.Boolean);
                    parametrs.Add("Note", sample.Note, DbType.String);
                    parametrs.Add("LocationId", sample.LocationId, DbType.Int32);
                    parametrs.Add("LastEditComment", sample.LastEditComment, DbType.String);
                    parametrs.Add("CreateTime", sample.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", sample.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", sample.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", sample.UpdateUser, DbType.String);
                    parametrs.Add("FinalizeUser", sample.FinalizeUser, DbType.String);
                    parametrs.Add("FinalizeTime", sample.FinalizeTime, DbType.DateTime);
                    await conn.ExecuteAsync("spSamples_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> SampleDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSamples_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
