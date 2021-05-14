using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LIMSBlazor.Data
{
    public interface IAspNetRoleService
    {
        Task<bool> AspNetRoleInsert(IdentityRole _identityRole);
        Task<List<IdentityRole>> AspNetRoleList();
        Task<IdentityRole> AspNetRole_GetOne(string id);
        Task<bool> AspNetRoleUpdate(IdentityRole _identityRole);
        Task<bool> AspNetRoleDelete(string id);
        Task<bool> AspNetRoleClassic(string code);
    }
}