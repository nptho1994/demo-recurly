using Recurly;
using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandleAccount
    {
        public string CreateAccountWithBillingInfo(string tokenID, string accountCode)
        {
            try
            {
                string index = DateTime.Now.ToString( "MMddHHmm", CultureInfo.InvariantCulture);
                if (string.IsNullOrWhiteSpace(accountCode)) accountCode = "Tho" + index;
                var accountReq = new AccountCreate()
                {
                    Code = accountCode,
                    FirstName = "Nguyen",
                    LastName = "Tho",
                    Address = new Address()
                    {
                        City = "New Orleans",
                        Region = "LA",
                        Country = "US",
                        PostalCode = "70115",
                        Street1 = "900 Camp St."
                    },
                    BillingInfo = new BillingInfoCreate
                    {
                        TokenId = tokenID
                    }
                };
                Account account = HandleClient.client.CreateAccount(accountReq);
                return $"Created account {account.Code}";
            }
            catch (Recurly.Errors.Validation ex)
            {
                // If the request was not valid, you may want to tell your user
                // why. You can find the invalid params and reasons in ex.Error.Params
                return $"Failed validation: {ex.Error.Message}";
            }
            catch (Recurly.Errors.ApiError ex)
            {
                // Use ApiError to catch a generic error from the API
                return $"Unexpected Recurly Error: {ex.Error.Message}";
            }
        }

        public string GetAccountIdByCode(string accountCode)
        {
            var accounts = HandleClient.client.ListAccounts();
            foreach (Account account in accounts)
            {
                if (account.Code == accountCode)
                    return account.Id;
            }
            return string.Empty;
        }

        public string GetListAccount()
        {
            var optionalParams = new ListAccountsParams()
            {
                Limit = 200
            };
            var accounts = HandleClient.client.ListAccounts(optionalParams);
            string listCode = string.Empty;
            foreach (Account account in accounts)
            {
                listCode += account.Code + "\t";
            }
            return listCode;
        }
    }
}
