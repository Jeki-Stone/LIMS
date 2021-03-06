using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Клиенты
    /// </summary>
    public class Cli
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Organization { get; set; }
    }
}
