using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class UnitService : IUnitService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public UnitService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> UnitInsert(Unit unit)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", unit.Name, DbType.String);
                    parametrs.Add("Scale", unit.Scale, DbType.String);
                    parametrs.Add("BaseUnitId", unit.BaseUnitId, DbType.String);
                    // Stored procedure method
                    await conn.ExecuteAsync("spUnits_Insert", parametrs, commandType: CommandType.StoredProcedure);

                    // Raw SQL method.
                    //const string query = @"INSERT INTO Labs(Code, Name, Location, Description) VALUES(@Code, @Name, @Location, @Description)";
                    //await conn.ExecuteAsync(query, new { lab.Code, lab.Name, lab.Location, lab.Description }, commandType: CommandType.Text);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        public async Task<IEnumerable<Unit>> UnitList()
        {
            IEnumerable<Unit> units;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                units = await conn.QueryAsync<Unit>("spUnits_GetAll", commandType: CommandType.StoredProcedure);
            }
            return units;
        }


        // Get one data based on its ID
        public async Task<Unit> Unit_GetOne(int id)
        {
            Unit unit = new Unit();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                unit = await conn.QueryFirstOrDefaultAsync<Unit>("spUnits_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return unit;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> UnitUpdate(Unit unit)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", unit.Id, DbType.Int32);
                    parametrs.Add("Name", unit.Name, DbType.String);
                    parametrs.Add("Scale", unit.Scale, DbType.String);
                    parametrs.Add("BaseUnitId", unit.BaseUnitId, DbType.String);
                    await conn.ExecuteAsync("spUnits_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> UnitDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spUnits_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
