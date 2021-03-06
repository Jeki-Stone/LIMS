using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Типы пробы / аналитический сервисы типа пробы
    /// </summary>
    public class SampleTypeAnalytical
    {
        public int SampleTypeId { get; set; }
        public int OldAnalyticalServiceId { get; set; }
        public int AnalyticalServiceId { get; set; }
    }
}
