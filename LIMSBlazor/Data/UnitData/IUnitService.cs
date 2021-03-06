using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IUnitService
    {
        Task<bool> UnitInsert(Unit unit);
        Task<IEnumerable<Unit>> UnitList();
        Task<Unit> Unit_GetOne(int Id);
        Task<bool> UnitUpdate(Unit unit);
        Task<bool> UnitDelete(int id);
    }
}