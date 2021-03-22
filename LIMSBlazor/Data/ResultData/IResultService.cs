using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IResultService
    {
        Task<bool> ResultInsert(Result result);

        Task<IEnumerable<Result>> ResultList(int sampleId);
        Task<Result> Result_GetOne(int Id);
        Task<bool> ResultUpdate(Result result);
        Task<bool> ResultDelete(int id);
    }
}