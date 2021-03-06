using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IInstrumTypeService
    {
        Task<bool> InstrumTypeInsert(InstrumType instrumtype);

        Task<IEnumerable<InstrumType>> InstrumTypeList();
        Task<InstrumType> InstrumType_GetOne(int Id);
        Task<bool> InstrumTypeUpdate(InstrumType instrumtype);
        Task<bool> InstrumTypeDelete(int id);
    }
}