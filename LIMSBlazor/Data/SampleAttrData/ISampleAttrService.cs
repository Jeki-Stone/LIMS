using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ISampleAttrService
    {
        Task<bool> SampleAttrInsert(SampleAttr sampleattr, int SampleId);
        Task<IEnumerable<SampleAttr>> SampleAttrList();
        Task<SampleAttr> SampleAttr_GetOne(int SampleId, int AttrId);
        Task<bool> SampleAttrUpdate(SampleAttr sampleattr);
        Task<bool> SampleAttrDelete(int SampleId, int AttrId);
    }
}