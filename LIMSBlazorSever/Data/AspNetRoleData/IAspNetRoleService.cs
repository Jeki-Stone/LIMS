using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IAspNetRoleService
    {
        Task<bool> AspNetRoleInsert(AspNetRole aspNetRole);
        Task<IEnumerable<AspNetRole>> AspNetRoleList();
        Task<AspNetRole> AspNetRole_GetOne(string id);
        Task<bool> AspNetRoleUpdate(AspNetRole aspNetRole);
        Task<bool> AspNetRoleDelete(string id);
    }
}