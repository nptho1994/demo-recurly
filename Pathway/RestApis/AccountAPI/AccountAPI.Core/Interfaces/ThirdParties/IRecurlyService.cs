using System.Threading.Tasks;
using AccountAPI.Core.Domains;
using AccountAPI.Core.Domains.Entities;

namespace AccountAPI.Core.Interfaces.ThirdParties
{
    public interface IRecurlyService
    {
        Task<Account> GetAccountDetails(string query);
    }
}
