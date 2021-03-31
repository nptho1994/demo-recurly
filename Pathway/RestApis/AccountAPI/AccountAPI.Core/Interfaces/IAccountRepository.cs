using AccountAPI.Core.Domains.Entities;
using AccountAPI.Core.Interfaces.Repositories;

namespace AccountAPI.Core.Interfaces
{
    public interface IAccountRepository:IRepository<Account>
    {
        bool Create(Account accountDetails);
    }
}
