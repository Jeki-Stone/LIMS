using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IAnalyticalServService
    {
        Task<bool> AnalyticalServInsert(AnalyticalServ analyticalserv);
        Task<IEnumerable<AnalyticalServ>> AnalyticalServList();
        Task<AnalyticalServ> AnalyticalServ_GetOne(int Id);
        Task<bool> AnalyticalServUpdate(AnalyticalServ analyticalserv);
        Task<bool> AnalyticalServDelete(int id);
    }
}