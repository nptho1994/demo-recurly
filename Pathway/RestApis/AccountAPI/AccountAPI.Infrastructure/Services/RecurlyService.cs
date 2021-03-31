using System.Threading.Tasks;
using AccountAPI.Core.Domains;
using AccountAPI.Core.Domains.Common;
using AccountAPI.Core.Interfaces.ThirdParties;
using Microsoft.Extensions.Configuration;

namespace AccountAPI.Infrastructure.Services
{
    public class RecurlyService : IRecurlyService
    {
        private readonly RecurlySettings recurlySettings;
        private readonly Recurly.Client client;

        public RecurlyService(IConfiguration configuration)
        {
            recurlySettings = new RecurlySettings
            {
                Key = configuration["RecurlySettings:Key"]
            };
            client = new Recurly.Client(recurlySettings.Key);

        }
        public async Task<Account> GetAccountDetails(string accountCode)
        {

            var sub = await client.GetAccountAsync(accountCode);
            var response = new Account
            {
                Email = sub.Email
            };

            return response;

        }
    }
}
