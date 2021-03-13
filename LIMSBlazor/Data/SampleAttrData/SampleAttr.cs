using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Проба / атребут пробы
    /// </summary>
    public class SampleAttr : IAttr
    {
        public int SampleId { get; set; }
        public int OldAttrId { get; set; }
        public int AttrId { get; set; }
        public string Value { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
    }
}
