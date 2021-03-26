using HandleRecurly.Config;
using Newtonsoft.Json;
using Recurly.Resources;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandleBillingInfo
    {
        public string GetBillingInfoToken()
        {
            CheckFunction checkFunction = new CheckFunction();
            return checkFunction.CallApiGetTokenBillingInfo();
        }

        public string GetBillingInfo(string accountId)
        {
            try
            {
                BillingInfo billingInfo = HandleClient.client.GetBillingInfo(accountId);
                return $"Fetched billing info {billingInfo.Id}";
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

        public BillingInfo GetBillingInfoById(string accountId, string billingId)
        {
            try
            {
                BillingInfo billingInfo = HandleClient.client.GetABillingInfo(accountId, billingId);
                return billingInfo;
            }
            catch (Recurly.Errors.NotFound)
            {
                // If the resource was not found
                // we may want to alert the user or just return null
                return null;
            }
            catch (Recurly.Errors.ApiError)
            {
                // Use ApiError to catch a generic error from the API
                return null;
            }

        }
    }
}
