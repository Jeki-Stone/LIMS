using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class AttrService : IAttrService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public AttrService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> AttrInsert(Attr attr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Name", attr.Name, DbType.String);
                    parametrs.Add("Description", attr.Description, DbType.String);
                    parametrs.Add("Type", attr.Type, DbType.String);
                    parametrs.Add("Options", attr.Options, DbType.String);
                    // Stored procedure method
                    await conn.ExecuteAsync("spAttrs_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<Attr>> AttrList()
        {
            IEnumerable<Attr> attrs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                attrs = await conn.QueryAsync<Attr>("spAttrs_GetAll", commandType: CommandType.StoredProcedure);
            }
            return attrs;
        }


        // Get one data based on its ID
        public async Task<Attr> Attr_GetOne(int id)
        {
            Attr attr = new Attr();
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                attr = await conn.QueryFirstOrDefaultAsync<Attr>("spAttrs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return attr;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> AttrUpdate(Attr attr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("Id", attr.Id, DbType.Int32);
                    parametrs.Add("Name", attr.Name, DbType.String);
                    parametrs.Add("Description", attr.Description, DbType.String);
                    parametrs.Add("Type", attr.Type, DbType.String);
                    parametrs.Add("Options", attr.Options, DbType.String);
                    await conn.ExecuteAsync("spAttrs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> AttrDelete(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", id, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spAttrs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
