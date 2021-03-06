using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public class IFinalResult
    {
        public int Id { get; set; }
        public int SampleId { get; set; }
        public int AnalyticalServiceId { get; set; }
        public int InstrumentId { get; set; }
        public string ValueNo { get; set; }
        public float Value { get; set; }
        public int UnitId { get; set; }        
        public bool? IsFinal { get; set; }
        public string Note { get; set; }
    }
}
