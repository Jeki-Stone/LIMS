using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ISampleTypeService
    {
        Task<bool> SampleTypeInsert(SampleType sampletype);
        Task<IEnumerable<SampleType>> SampleTypeList();
        Task<SampleType> SampleType_GetOne(int Id);
        Task<bool> SampleTypeUpdate(SampleType sampletype);
        Task<bool> SampleTypeDelete(int id);
    }
}