using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Единицы измерения
    /// </summary>
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Scale { get; set; }
        public string BaseUnitId { get; set; }
    }
}
