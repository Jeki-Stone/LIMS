using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IFinalResultService
    {
        Task<bool> FinalResultInsert(FinalResult finalresult);

        Task<IEnumerable<FinalResult>> FinalResultList(int SampleId);
        Task<FinalResult> FinalResult_GetOne(int Id);
        Task<bool> FinalResultUpdate(FinalResult finalresult);
        Task<bool> FinalResultDelete(int id);
    }
}