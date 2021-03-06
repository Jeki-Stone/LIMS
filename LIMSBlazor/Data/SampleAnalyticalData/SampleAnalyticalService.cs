using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class SampleAnalyticalService : ISampleAnalyticalService
    {
        // Database connection
        private readonly SqlConnectionConfiguration _configuration;
        public SampleAnalyticalService(SqlConnectionConfiguration configuration)
        {
            _configuration = configuration;
        }

        // Add (create) a data in table row (SQL Insert)

        public async Task<bool> SampleAnalyticalInsert(SampleAnalytical sampleanalytical, int SampleId)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", SampleId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", sampleanalytical.AnalyticalServiceId, DbType.Int32);
                    // Stored procedure method
                    await conn.ExecuteAsync("spSampleAnalyticals_Insert", parametrs, commandType: CommandType.StoredProcedure);

                    //foreach (var item in sampletypeanalyticals)
                    //{
                    //    if (sample.SampleTypeId == item.SampleTypeId)
                    //    {
                    //        sampleanalytical.AnalyticalServiceId = item.AnalyticalServiceId;
                    //        await SampleAnalyticalService.SampleAnalyticalInsert(sampleanalytical, sample.Id);
                    //    }
                    //}
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        public async Task<IEnumerable<SampleAnalytical>> SampleAnalyticalList()
        {
            IEnumerable<SampleAnalytical> sampleanalyticals;
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampleanalyticals = await conn.QueryAsync<SampleAnalytical>("spSampleAnalyticals_GetAll", commandType: CommandType.StoredProcedure);
            }
            return sampleanalyticals;
        }


        // Get one data based on its ID
        public async Task<SampleAnalytical> SampleAnalytical_GetOne(int SampleId, int AnalyticalServiceId)
        {
            SampleAnalytical sampleanalytical = new SampleAnalytical();
            var parameters = new DynamicParameters();
            parameters.Add("SampleId", SampleId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                sampleanalytical = await conn.QueryFirstOrDefaultAsync<SampleAnalytical>("spSampleAnalyticals_GetOne", parameters, commandType: CommandType.StoredProcedure);
            }
            return sampleanalytical;
        }

        // Add (create) a data table row (SQL Update)
        public async Task<bool> SampleAnalyticalUpdate(SampleAnalytical sampleanalytical)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.Value))
                {
                    var parametrs = new DynamicParameters();
                    parametrs.Add("SampleId", sampleanalytical.SampleId, DbType.Int32);
                    parametrs.Add("OldAnalyticalServiceId", sampleanalytical.OldAnalyticalServiceId, DbType.Int32);
                    parametrs.Add("AnalyticalServiceId", sampleanalytical.AnalyticalServiceId, DbType.Int32);
                    await conn.ExecuteAsync("spSampleAnalyticals_Update", parametrs, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }

        //Delete Data
        public async Task<bool> SampleAnalyticalDelete(int SampleId, int AnalyticalServiceId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("SampleId", SampleId, DbType.Int32);
            parameters.Add("AnalyticalServiceId", AnalyticalServiceId, DbType.Int32);
            using (var conn = new SqlConnection(_configuration.Value))
            {
                await conn.ExecuteAsync("spSampleAnalyticals_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
            return true;
        }
    }
}
