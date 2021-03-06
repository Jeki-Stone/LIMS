using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface IUserService
    {
        Task<bool> UserInsert(User user);

        Task<IEnumerable<User>> UserList();
        Task<User> User_GetOne(int Id);
        Task<bool> UserUpdate(User user);
        Task<bool> UserDelete(int id);
    }
}