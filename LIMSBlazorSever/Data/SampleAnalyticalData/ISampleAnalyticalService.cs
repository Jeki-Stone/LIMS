using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISampleAnalyticalService
    {
        Task<bool> SampleAnalyticalInsert(SampleAnalytical sampleanalytical, int SampleId);
        Task<IEnumerable<SampleAnalytical>> SampleAnalyticalList();
        Task<SampleAnalytical> SampleAnalytical_GetOne(int SampleId, int AnalyticalServiceId);
        Task<bool> SampleAnalyticalUpdate(SampleAnalytical sampletypeanalytical);
        Task<bool> SampleAnalyticalDelete(int SampleId, int AnalyticalServiceId);
    }
}