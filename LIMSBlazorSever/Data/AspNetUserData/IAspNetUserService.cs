using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LIMSBlazor.Data
{
    public interface IAspNetUserService
    {
        Task<bool> AspNetUserInsert(IdentityUser user, string password);
        Task<List<IdentityUser>> AspNetUserList();
        Task<List<IdentityUser>> AspNetUserClientList();
        Task<IdentityUser> AspNetUser_GetOne(string id);
        Task<bool> AspNetUserUpdate(IdentityUser _identityUser);
        Task<bool> AspNetUserDelete(string id);
    }
}