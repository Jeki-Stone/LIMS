using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IInstrumTypeAnalyticService
    {
        Task<bool> InstrumTypeAnalyticInsert(InstrumTypeAnalytic instrumtypeanalitic, int InstrumentTypeId);
        Task<IEnumerable<InstrumTypeAnalytic>> InstrumTypeAnalyticList();
        Task<InstrumTypeAnalytic> InstrumTypeAnalytic_GetOne(int InstrumentTypeId, int AnalyticalServiceId);
        Task<bool> InstrumTypeAnalyticUpdate(InstrumTypeAnalytic instrumtypeanalytic);
        Task<bool> InstrumTypeAnalyticDelete(int InstrumentTypeId, int AnalyticalServiceId);
    }
}