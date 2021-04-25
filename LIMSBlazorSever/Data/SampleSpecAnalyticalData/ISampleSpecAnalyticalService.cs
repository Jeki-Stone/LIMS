using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ISampleSpecAnalyticalService
    {
        Task<bool> SampleSpecAnalyticalInsert(SampleSpecAnalytical samplespecanalitical);
        Task<IEnumerable<SampleSpecAnalytical>> SampleSpecAnalyticalList(int SampleSpecId);
        Task<SampleSpecAnalytical> SampleSpecAnalytical_GetOne(int SampleSpecId, int AnalyticalServiceId);
        Task<bool> SampleSpecAnalyticalUpdate(SampleSpecAnalytical samplespecanalytical);
        Task<bool> SampleSpecAnalyticalDelete(int SampleSpecId, int AnalyticalServiceId);
    }
}