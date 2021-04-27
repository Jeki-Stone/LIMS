using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IAspNetUserService
    {
        Task<IEnumerable<AspNetUser>> AspNetUserList();
        Task<AspNetUser> AspNetUser_GetOne(string id);
        Task<bool> AspNetUserUpdate(AspNetUser UserName);
        Task<bool> AspNetUserDelete(string id);
    }
}