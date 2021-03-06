using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IUserRoleService
    {
        Task<bool> UserRoleInsert(UserRole userrole, int UserId);
        Task<IEnumerable<UserRole>> UserRoleList();
        Task<UserRole> UserRole_GetOne(int UserId, int LabId, int RoleId);
        Task<bool> UserRoleUpdate(UserRole userrole);
        Task<bool> UserRoleDelete(int UserId, int LabId, int RoleId);
    }
}