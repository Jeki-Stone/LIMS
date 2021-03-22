using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Результаты испытаний
    /// </summary>
    public class FinalResult
    {
        public int Id { get; set; }
        public int SampleId { get; set; }
        public int AnalyticalServiceId { get; set; }
        public string ValueNo { get; set; }
        public float Value { get; set; }
        public bool? IsFinal { get; set; }
        public string Note { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
    }
}
