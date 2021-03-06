using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Типы пробы / аналитический сервисы пробы
    /// </summary>
    public class SampleAnalytical
    {
        public int SampleId { get; set; }
        public int OldAnalyticalServiceId { get; set; }
        public int AnalyticalServiceId { get; set; }
    }
}
