using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    /// <summary>
    /// Роли пользователей
    /// </summary>
    public class UserRole
    {
        public int UserId { get; set; }
        public int OldLabId { get; set; }
        public int OldRoleId { get; set; }
        public int LabId { get; set; }        
        public int RoleId { get; set; }
    }
}
