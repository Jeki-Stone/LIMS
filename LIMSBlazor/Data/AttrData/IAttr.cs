using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IAttr
    {
        public int AttrId { get; set; }
        public string Value { get; set; }
    }
}