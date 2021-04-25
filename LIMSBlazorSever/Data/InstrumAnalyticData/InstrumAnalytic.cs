using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Типы инструментов / аналитический сервисы инструментта
    /// </summary>
    public class InstrumAnalytic
    {
        public int InstrumentId { get; set; }
        public int OldAnalyticalServiceId { get; set; }
        public int AnalyticalServiceId { get; set; }
        public int LabId { get; set; }
    }
}
