using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ILocService
    {
        Task<bool> LocInsert(Loc loc);
        Task<IEnumerable<Loc>> LocList();
        Task<Loc> Loc_GetOne(int Id);
        Task<bool> LocUpdate(Loc loc);
        Task<bool> LocDelete(int id);
    }
}