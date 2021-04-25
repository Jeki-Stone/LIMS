using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IRoleService
    {
        Task<bool> RoleInsert(Role role);
        Task<IEnumerable<Role>> RoleList();
        Task<Role> Role_GetOne(int Id);
        Task<bool> RoleUpdate(Role role);
        Task<bool> RoleDelete(int id);
    }
}