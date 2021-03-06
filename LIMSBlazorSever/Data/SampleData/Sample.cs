using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Образцы испытаний
    /// </summary>
    public class Sample
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:nn}", ApplyFormatInEditMode = true)]
        public DateTime RecieveTime { get; set; } = DateTime.Now;
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:nn}", ApplyFormatInEditMode = true)]
        public DateTime? TestTime { get; set; }
        [Required]
        [Range(1, 10000000, ErrorMessage = "Age must be between 18 and 80.")]
        public string UserId { get; set; }
        public int LabId { get; set; }
        public int SampleTypeId { get; set; }
        public int NumSamples { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Age must be between 18 and 80.")]
        public int Status { get; set; }
        public bool IsFinal { get; set; }
        public string Note { get; set; }
        public int LocationId { get; set; }
        public string LastEditComment { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime? UpdateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string FinalizeUser { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:nn}", ApplyFormatInEditMode = true)]
        public DateTime? FinalizeTime { get; set; }

    }
}
