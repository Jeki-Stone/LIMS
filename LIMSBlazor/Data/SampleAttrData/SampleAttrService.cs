using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleAttrService : ISampleAttrService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public SampleAttrService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> SampleAttrInsert(SampleAttr sampleattr, int SampleId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", SampleId, DbType.Int32);
                    parametrs.Add("AttrId", sampleattr.AttrId, DbType.Int32);
                    parametrs.Add("Value", sampleattr.Value, DbType.String);
                    parametrs.Add("CreateTime", sampleattr.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", sampleattr.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", sampleattr.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", sampleattr.UpdateUser, DbType.String);
                    // Stored procedure method
                    await conn.ExecuteAsync("spSampleAttrs_Insert", parametrs, commandType: CommandType.StoredProcedure);

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

        public async Task<IEnumerable<SampleAttr>> SampleAttrList(int SampleId)
        {
            IEnumerable<SampleAttr> sampleattrs;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                var parametrs = new DynamicParameters();
                parametrs.Add("SampleId", SampleId, DbType.Int32);
                sampleattrs = await conn.QueryAsync<SampleAttr>("spSampleAttrs_GetAll", parametrs, commandType: CommandType.StoredProcedure);
            }
            return sampleattrs;
        }


        // Get one data based on its ID
        public async Task<SampleAttr> SampleAttr_GetOne(int SampleId, int AttrId)
        {
            SampleAttr sampleattr = new SampleAttr();
            var parameters = new DynamicParameters();
            parameters.Add("SampleId", SampleId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampleattr = await conn.QueryFirstOrDefaultAsync<SampleAttr>("spSampleAttrs_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return sampleattr;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> SampleAttrUpdate(SampleAttr sampleattr)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", sampleattr.SampleId, DbType.Int32);
                    parametrs.Add("AttrId", sampleattr.AttrId, DbType.Int32);
                    parametrs.Add("OldAttrId", sampleattr.OldAttrId, DbType.Int32);
                    parametrs.Add("Value", sampleattr.Value, DbType.String);
                    parametrs.Add("CreateTime", sampleattr.CreateTime, DbType.DateTime);
                    parametrs.Add("UpdateTime", sampleattr.UpdateTime, DbType.DateTime);
                    parametrs.Add("CreateUser", sampleattr.CreateUser, DbType.String);
                    parametrs.Add("UpdateUser", sampleattr.UpdateUser, DbType.String);
                    await conn.ExecuteAsync("spSampleAttrs_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> SampleAttrDelete(int SampleId, int AttrId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleId", SampleId, DbType.Int32);
            parameters.Add("AttrId", AttrId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleAttrs_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
