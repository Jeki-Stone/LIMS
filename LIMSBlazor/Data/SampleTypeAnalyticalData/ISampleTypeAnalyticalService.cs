using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ISampleTypeAnalyticalService
    {
        Task<bool> SampleTypeAnalyticalInsert(SampleTypeAnalytical sampletypeanalytical, int SampleTypeId);
        Task<IEnumerable<SampleTypeAnalytical>> SampleTypeAnalyticalList(int SampleTypeId);
        Task<SampleTypeAnalytical> SampleTypeAnalytical_GetOne(int SampleTypeId, int AnalyticalServiceId);
        Task<bool> SampleTypeAnalyticalUpdate(SampleTypeAnalytical sampletypeanalytical);
        Task<bool> SampleTypeAnalyticalDelete(int SampleTypeId, int AnalyticalServiceId);
    }
}