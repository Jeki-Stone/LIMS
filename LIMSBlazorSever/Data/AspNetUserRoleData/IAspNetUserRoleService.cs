using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LIMSBlazor.Data
{
    public interface IAspNetUserRoleService
    {
        Task<bool> UserRoleInsert(string UserId, string RoleId);
        Task<IList<string>> UserRoleList(string UserId);
        Task<bool> UserRoleDelete(string UserId, string RoleName);
        Task<bool> UserHaveRole(string UserId, string roleName);
        Task<List<Lab>> UserByNameLab(string UserName);
    }
}