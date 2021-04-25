using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Оборудование
    /// </summary>
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstrumentTypeId { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public int LabId { get; set; }
        public int Status { get; set; }
    }
}
