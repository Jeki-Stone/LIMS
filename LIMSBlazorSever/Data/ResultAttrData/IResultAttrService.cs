using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IResultAttrService
    {
        Task<bool> ResultAttrInsert(ResultAttr resultattr);
        Task<IEnumerable<ResultAttr>> ResultAttrList(int SampleId, int AnalyticalServiceId);
        Task<ResultAttr> ResultAttr_GetOne(int SampleId, int AnalyticalServiceId, int AttrId);
        Task<bool> ResultAttrUpdate(ResultAttr resultattr);
        Task<bool> ResultAttrDelete(int SampleId, int AnalyticalServiceId, int AttrId);
    }
}