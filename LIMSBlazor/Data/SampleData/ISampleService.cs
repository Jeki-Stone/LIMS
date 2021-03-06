using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ISampleService
    {
        Task<Sample> SampleInsert(Sample sample);
        Task<IEnumerable<Sample>> SampleList();
        Task<Sample> Sample_GetOne(int Id);
        Task<bool> SampleUpdate(Sample sample);
        Task<bool> SampleDelete(int id);
    }
}