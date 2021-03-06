using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ISampleTypeAttrService
    {
        Task<bool> SampleTypeAttrInsert(SampleTypeAttr sampletypeattr, int SampleTypeId);
        Task<IEnumerable<SampleTypeAttr>> SampleTypeAttrList();
        Task<SampleTypeAttr> SampleTypeAttr_GetOne(int SampleTypeId, int AttrId);
        Task<bool> SampleTypeAttrUpdate(SampleTypeAttr sampletypeattr);
        Task<bool> SampleTypeAttrDelete(int SampleTypeId, int AttrId);
    }
}