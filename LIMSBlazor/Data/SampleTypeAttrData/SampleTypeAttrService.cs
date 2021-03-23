using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleTypeAttrService : ISampleTypeAttrService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public SampleTypeAttrService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> SampleTypeAttrInsert(SampleTypeAttr sampletypeattr, int SampleTypeId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleTypeId", SampleTypeId, DbType.Int32);
                    parametrs.Add("AttrId", sampletypeattr.AttrId, DbType.Int32);
                    // Stored procedure method
                    await conn.ExecuteAsync("spSampleTypeAttrs_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<SampleTypeAttr>> SampleTypeAttrList(int SampleTypeId)
        {
            IEnumerable<SampleTypeAttr> sampletypeattrs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("SampleTypeId", SampleTypeId, DbType.Int32);
                sampletypeattrs = await conn.QueryAsync<SampleTypeAttr>("spSampleTypeAttrs_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return sampletypeattrs;
        }


        // Get one data based on its ID
        public async Task<SampleTypeAttr> SampleTypeAttr_GetOne(int SampleTypeId, int AttrId)
        {
            SampleTypeAttr sampletypeattr = new SampleTypeAttr();
            var parameters = new DynamicParameters();
            parameters.Add("SampleTypeId", SampleTypeId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampletypeattr = await conn.QueryFirstOrDefaultAsync<SampleTypeAttr>("spSampleTypeAttrs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return sampletypeattr;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> SampleTypeAttrUpdate(SampleTypeAttr sampletypeattr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleTypeId", sampletypeattr.SampleTypeId, DbType.Int32);
                    parametrs.Add("OldAttrId", sampletypeattr.OldAttrId, DbType.Int32);
                    parametrs.Add("AttrId", sampletypeattr.AttrId, DbType.Int32);
                    await conn.ExecuteAsync("spSampleTypeAttrs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> SampleTypeAttrDelete(int SampleTypeId, int AttrId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleTypeId", SampleTypeId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleTypeAttrs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
