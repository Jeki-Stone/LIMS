using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class InstrumentService : IInstrumentService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public InstrumentService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<Instrument> InstrumentInsert(Instrument instrument)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", instrument.Name, DbType.String);
                    parametrs.Add("InstrumentTypeId", instrument.InstrumentTypeId, DbType.Int32);
                    parametrs.Add("SerialNumber", instrument.SerialNumber, DbType.String);
                    parametrs.Add("Description", instrument.Description, DbType.String);
                    parametrs.Add("LabId", instrument.LabId, DbType.Int32);
                    parametrs.Add("Status", instrument.Status, DbType.Int32);
                    parametrs.Add("Id", instrument.Id, DbType.Int32, ParameterDirection.Output);
                    await conn.ExecuteAsync("spInstruments_Insert", parametrs, commandType: CommandType.StoredProcedure);
                    var Id = parametrs.Get<int>("Id");
                    return await Instrument_GetOne(Id);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<Instrument>> InstrumentList()
        {
            IEnumerable<Instrument> instruments;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                instruments = await conn.QueryAsync<Instrument>("spInstruments_GetAll", commandType: CommandType.StoredProcedure);
            }
            return instruments;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<Instrument> Instrument_GetOne(int id)
        {
            Instrument instrument = new Instrument();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                instrument = await conn.QueryFirstOrDefaultAsync<Instrument>("spInstruments_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return instrument;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> InstrumentUpdate(Instrument instrument)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", instrument.Id, DbType.Int32);
                    parametrs.Add("Name", instrument.Name, DbType.String);
                    parametrs.Add("InstrumentTypeId", instrument.InstrumentTypeId, DbType.Int32);
                    parametrs.Add("SerialNumber", instrument.SerialNumber, DbType.String);
                    parametrs.Add("Description", instrument.Description, DbType.String);
                    parametrs.Add("LabId", instrument.LabId, DbType.Int32);
                    parametrs.Add("Status", instrument.Status, DbType.Int32);
                    await conn.ExecuteAsync("spInstruments_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> InstrumentDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spInstruments_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
