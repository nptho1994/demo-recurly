using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandlePurchase
    {
        public string Create(string accountCode, string rjsTokenId, string planCode)
        {
            try
            {
                string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
                var purchaseReq = new PurchaseCreate()
                {
                    Currency = "VND",
                    Account = new AccountPurchase()
                    {
                        Code = accountCode,
                        FirstName = "Purchase",
                        LastName = index,
                        BillingInfo = new BillingInfoCreate()
                        {
                            TokenId = rjsTokenId
                        }
                    },
                    Subscriptions = new List<SubscriptionPurchase>()
                    {
                        new SubscriptionPurchase() { PlanCode = planCode }
                    }
                };
                InvoiceCollection collection = HandleClient.client.CreatePurchase(purchaseReq);
                
                return $"Created ChargeInvoice with Number: {collection.ChargeInvoice.Number}";
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

        public string Preview(string accountCode, string rjsTokenId, string planCode)
        {
            try
            {
                string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
                var purchaseReq = new PurchaseCreate()
                {
                    Currency = "VND",
                    Account = new AccountPurchase()
                    {
                        Code = accountCode,
                        FirstName = "Purchase",
                        LastName = index,
                        BillingInfo = new BillingInfoCreate()
                        {
                            TokenId = rjsTokenId
                        }
                    },
                    Subscriptions = new List<SubscriptionPurchase>()
                    {
                        new SubscriptionPurchase() { PlanCode = planCode }
                    }
                };
                InvoiceCollection collection = HandleClient.client.PreviewPurchase(purchaseReq);
                return $"Preview ChargeInvoice with Total: {collection.ChargeInvoice.Total}";
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
    }
}
