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
    public class Result : IResult
    {
        public int Id { get; set; }
        public int SampleId { get; set; }
        public int AnalyticalServiceId { get; set; }
        public int InstrumentId { get; set; }
        public int UnitId { get; set; }
        public int ValueNo { get; set; }
        public float Value { get; set; }
        public bool? IsFinal { get; set; }
        public string Note { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:nn}", ApplyFormatInEditMode = true)]
        public DateTime CreateTime { get; set; } = DateTime.Now;
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:nn}", ApplyFormatInEditMode = true)]
        public DateTime? UpdateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
    }
}
