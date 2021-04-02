using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Атрибут результата испытания
    /// </summary>
    public class ResultAttr : IAttr
    {
        public int SampleId { get; set; }
        public int AnalyticalServiceId { get; set; }
        public int AttrId { get; set; }
        public string Value { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:nn}", ApplyFormatInEditMode = true)]
        public DateTime CreateTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:nn}", ApplyFormatInEditMode = true)]
        public DateTime UpdateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }

    }
}
