using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Лабаратория
    /// </summary>
    public class Lab
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int LocId { get; set; }
        public string Description { get; set; }
    }
}
