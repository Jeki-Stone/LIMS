using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ICategoryService
    {
        Task<bool> CategoryInsert(Category category);
        Task<IEnumerable<Category>> CategoryList();
        Task<Category> Category_GetOne(int Id);
        Task<bool> CategoryUpdate(Category category);
        Task<bool> CategoryDelete(int id);
    }
}