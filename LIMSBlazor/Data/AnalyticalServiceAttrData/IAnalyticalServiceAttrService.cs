using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IAnalyticalServiceAttrService
    {
        Task<bool> AnalyticalServiceAttrInsert(AnalyticalServiceAttr analyticalServiceAttr);
        Task<IEnumerable<AnalyticalServiceAttr>> AnalyticalServiceAttrList(int AnalyticalServiceId);
        Task<AnalyticalServiceAttr> AnalyticalServiceAttr_GetOne(int AnalyticalServiceId, int AttrId);
        Task<bool> AnalyticalServiceAttrUpdate(AnalyticalServiceAttr analyticalServiceAttr);
        Task<bool> AnalyticalServiceAttrDelete(int AnalyticalServiceId, int AttrId);
    }
}