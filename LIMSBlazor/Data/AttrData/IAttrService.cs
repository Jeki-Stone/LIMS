using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IAttrService
    {
        Task<bool> AttrInsert(Attr attr);
        Task<IEnumerable<Attr>> AttrList();
        Task<Attr> Attr_GetOne(int Id);
        Task<bool> AttrUpdate(Attr attr);
        Task<bool> AttrDelete(int id);
    }
}