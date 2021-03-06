using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Элементы спецификации
    /// </summary>
    public class SampleSpecAnalytical
    {
        public int SampleSpecId { get; set; }
        public int OldSampleSpecId { get; set; }
        public int AnalyticalServiceId { get; set; }
        public int OldAnalyticalServiceId { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
    }
}
