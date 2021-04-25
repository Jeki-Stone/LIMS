using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ILabService
    {
        Task<bool> LabInsert(Lab lab);

        Task<IEnumerable<Lab>> LabList();
        Task<Lab> Lab_GetOne(int Id);
        Task<bool> LabUpdate(Lab lab);
        Task<bool> LabDelete(int id);
    }
}