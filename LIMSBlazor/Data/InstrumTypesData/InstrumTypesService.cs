using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class InstrumTypeService : IInstrumTypeService
    {
        /// Подключение к базе данных
        private readonly SqlConnectionConfiguration _configuration;
        public InstrumTypeService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// Добавить (создать) данные в строке таблицы 
        public async Task<bool> InstrumTypeInsert(InstrumType instrumtype)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", instrumtype.Name, DbType.String);
                    parametrs.Add("Description", instrumtype.Description, DbType.String);
                    await conn.ExecuteAsync("spInstrumentTypes_Insert", parametrs, commandType: CommandType.StoredProcedure);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Запросить все денные из БД
        public async Task<IEnumerable<InstrumType>> InstrumTypeList()
        {
            IEnumerable<InstrumType> instrumtypes;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                instrumtypes = await conn.QueryAsync<InstrumType>("spInstrumentTypes_GetAll", commandType: CommandType.StoredProcedure);
            }
            return instrumtypes;
        }

        /// Получите одни данные на основе его идентификатора
        public async Task<InstrumType> InstrumType_GetOne(int id)
        {
            InstrumType instrumtype = new InstrumType();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                instrumtype = await conn.QueryFirstOrDefaultAsync<InstrumType>("spInstrumentTypes_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return instrumtype;
        }

        /// Обновить строку таблицы данных в БД
        public async Task<bool> InstrumTypeUpdate(InstrumType instrumtype)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", instrumtype.Id, DbType.Int32);
                    parametrs.Add("Name", instrumtype.Name, DbType.String);
                    parametrs.Add("Description", instrumtype.Description, DbType.String);
                    await conn.ExecuteAsync("spInstrumentTypes_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        /// Удалить строку таблицы данных из БД
        public async Task<bool> InstrumTypeDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spInstrumentTypes_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
