using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AccountAPI.Core.Interfaces;
using AccountAPI.Core.Interfaces.Handlers;
using AccountAPI.Core.Interfaces.Repositories;
using AccountAPI.Core.Interfaces.ThirdParties;

namespace AccountAPI.Core.Handlers
{
    public class AccountNotificationHandler : IAccountNotificationHandler
    {
        private readonly IRecurlyService recurlyService;
        private readonly IAccountRepository accountRepository;
        private readonly IUnitOfWork unitOfWork;

        public AccountNotificationHandler(IRecurlyService recurlyService, IAccountRepository accountRepository, IUnitOfWork unitOfWork)
        {
            this.recurlyService = recurlyService;
            this.accountRepository = accountRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> ProcessNotificationAsync(string accountCode)
        {
            //1. Get account details from Recurly
            var response = await recurlyService.GetAccountDetails(accountCode);

            //2. Validate in DB and insert
            response.CreatedBy = "test";
            response.LastModified = DateTime.Now;
            response.LastModifiedBy = "test";
            response.FirstName = "firstName";

            var account = accountRepository.Create(response);
            var saved = await unitOfWork.CommitAsync();
            //3. Insert to DB if not existed
            //4. Insert EzyVet

            return saved > 0;
        }
    }
}
