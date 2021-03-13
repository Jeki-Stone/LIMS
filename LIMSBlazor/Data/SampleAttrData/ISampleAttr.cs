using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ISampleAttr
    {
        public int SampleId { get; set; }
        public int OldAttrId { get; set; }
        public int AttrId { get; set; }
        public string Value { get; set; }
    }
}