using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IInstrumentService
    {
        Task<Instrument> InstrumentInsert(Instrument Instrument);
        Task<IEnumerable<Instrument>> InstrumentList();
        Task<Instrument> Instrument_GetOne(int Id);
        Task<bool> InstrumentUpdate(Instrument instrument);
        Task<bool> InstrumentDelete(int Id);
    }
}