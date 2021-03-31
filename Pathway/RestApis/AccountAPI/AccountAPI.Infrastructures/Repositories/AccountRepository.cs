using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AccountAPI.Core.Domains;
using AccountAPI.Core.Domains.Entities;
using AccountAPI.Core.Interfaces;
using AccountAPI.Core.Interfaces.Repositories;
using AccountAPI.Infrastructures.EFCore;

namespace AccountAPI.Infrastructures.Repositories
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public AccountRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public bool Create(Account accountDetails)
        {
            if (accountDetails != null)
            {
                if (string.IsNullOrEmpty(accountDetails.Email)) 
                    return false;

                var newAccount = new Account
                {
                    Email = accountDetails.Email
                };
                Add(newAccount);
                return true;

            }

            return false;
        }
    }
}
