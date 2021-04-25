using System.Collections.Generic;
using System.Threading.Tasks;

namespace LIMSBlazor.Data
{
    public interface ICliService
    {
        Task<bool> CliInsert(Cli cli);
        Task<IEnumerable<Cli>> CliList();
        Task<Cli> Cli_GetOne(int Id);
        Task<bool> CliUpdate(Cli cli);
        Task<bool> CliDelete(int id);
        Task<Cli> Cli_GetLogin(string Name, string Password);
    }
}