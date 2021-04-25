using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ISampleSpecService
    {
        Task<bool> SampleSpecInsert(SampleSpec samplespec);
        Task<IEnumerable<SampleSpec>> SampleSpecList();
        Task<SampleSpec> SampleSpec_GetOne(int Id);
        Task<bool> SampleSpecUpdate(SampleSpec samplespec);
        Task<bool> SampleSpecDelete(int id);
    }
}