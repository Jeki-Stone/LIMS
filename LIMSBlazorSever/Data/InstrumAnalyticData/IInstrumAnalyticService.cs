using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IInstrumAnalyticService
    {
        Task<bool> InstrumAnalyticInsert(InstrumAnalytic instrumanalitic, int InstrumentId);
        Task<IEnumerable<InstrumAnalytic>> InstrumAnalyticList(int SampleId);
        Task<InstrumAnalytic> InstrumAnalytic_GetOne(int InstrumentId, int AnalyticalServiceId);
        Task<bool> InstrumAnalyticUpdate(InstrumAnalytic instrumanalytic);
        Task<bool> InstrumAnalyticDelete(int InstrumentId, int AnalyticalServiceId);
    }
}