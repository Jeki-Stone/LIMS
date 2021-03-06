using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Типы инструментов / аналитический сервисы типа
    /// </summary>
    public class InstrumTypeAnalytic
    {
        public int InstrumentTypeId { get; set; }
        public int OldAnalyticalServiceId { get; set; }
        public int AnalyticalServiceId { get; set; }
    }
}
