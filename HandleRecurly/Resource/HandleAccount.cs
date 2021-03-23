using Recurly;
using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
                //Email = "willdross@gmail.com",
                Limit = 200
            };
            var accounts = HandleClient.client.ListAccounts(optionalParams);
            List<string> lstEmail = new List<string>();
            string listCode = string.Empty;
            foreach (Account account in accounts)
            {
                listCode += account.Code + "\t";
                lstEmail.Add(account.Email);
            }
            var duplicateItems = lstEmail.GroupBy(x => x).Where(x => x.Count() > 1).ToList();
            return listCode;
        }

        public string CreateAccount(string accountCode)
        {
            try
            {
                string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
                if (string.IsNullOrWhiteSpace(accountCode)) accountCode = "Tho" + index;
                var accountReq = new AccountCreate()
                {
                    Code = accountCode,
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

        public string DeActiveAccount(string accountId)
        {
            try
            {
                Account account = HandleClient.client.DeactivateAccount(accountId);
                return $"Deactivated account {account.Code}";
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

        public string GetListChillAccount(string text)
        {
            return string.Empty;
        }

        public string FetchAccountBalance(string accountId)
        {
            try
            {
                AccountBalance balance = HandleClient.client.GetAccountBalance(accountId);
                return $"Fetched account balance {balance.Balances}";
            }
            catch (Recurly.Errors.NotFound ex)
            {
                // If the resource was not found
                // we may want to alert the user or just return null
                return $"Resource Not Found: {ex.Error.Message}";
            }
            catch (Recurly.Errors.ApiError ex)
            {
                // Use ApiError to catch a generic error from the API
                return $"Unexpected Recurly Error: {ex.Error.Message}";
            }

        }

        public string ReActiveAccount(string accountId)
        {
            try
            {
                Account account = HandleClient.client.ReactivateAccount(accountId);
                return $"Reactivated account {account.Code}";
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

        public string UpdateAccount(string accountId, string tokenID)
        {
            try
            {
                string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
                var accountReq = new AccountUpdate()
                {
                    FirstName = "Aaron",
                    LastName = "Du Monde",
                    BillingInfo = new BillingInfoCreate
                    {
                        TokenId = tokenID
                    },
                    CustomFields = new List<CustomField>()
                    {
                        new CustomField()
                        {
                            Name = "Test_Pet",
                            Value = index
                        }
                    }
                };
                Account account = HandleClient.client.UpdateAccount(accountId, accountReq);
                return account.FirstName;
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

        public string FetchAccount(string accountId)
        {
            try
            {
                Account account = HandleClient.client.GetAccount(accountId);
                return $"Fetched account {account.Code}";
            }
            catch (Recurly.Errors.NotFound ex)
            {
                // If the resource was not found
                // we may want to alert the user or just return null
                return $"Resource Not Found: {ex.Error.Message}";
            }
            catch (Recurly.Errors.ApiError ex)
            {
                // Use ApiError to catch a generic error from the API
                return $"Unexpected Recurly Error: {ex.Error.Message}";
            }
        }
    }
}
