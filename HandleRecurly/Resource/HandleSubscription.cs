using HandleRecurly.Config;
using Newtonsoft.Json;
using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandleRecurly.Resource
{
    class HandleSubscription
    {
        public string CreateSubscription(string planCode, string accountCode)
        {
            try
            {
                var subReq = new SubscriptionCreate()
                {
                    Currency = SettingRecurly.RECURLY_CURRENCE,
                    Account = new AccountCreate()
                    {
                        Code = accountCode,
                    },
                    PlanCode = planCode,
                    AutoRenew = false
                    
                };
                Subscription subscription = HandleClient.client.CreateSubscription(subReq);
                return $"Created Subscription with Id: {subscription.Uuid}";
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

        public string CancelSubscription(string subscriptionId)
        {
            try
            {
                var subReq = new SubscriptionCancel()
                {
                   
                };
                Subscription subscription = HandleClient.client.CancelSubscription(subscriptionId);
                return $"Canceled Subscription {subscription.Uuid}";
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

        public string GetListSubscriptionByAccount(string accountId)
        {
            var subscriptions = HandleClient.client.ListAccountSubscriptions(accountId);
            string listSubscription = string.Empty;
            foreach (Subscription subscription in subscriptions)
            {
                listSubscription += subscription.Id + "\t";
            }
            return listSubscription;
        }

        public string FetchSubscriptionByPlanAccount(string accountId, string planId)
        {
            var subscriptions = HandleClient.client.ListAccountSubscriptions(accountId);
            foreach (Subscription subscription in subscriptions)
            {
                if (subscription.Plan.Id == planId)
                    return subscription.Id;
            }
            return string.Empty;

        }

        public string FetchSubscription(string subscriptionId)
        {
            try
            {
                Subscription subscription = HandleClient.client.GetSubscription(subscriptionId);
                return JsonConvert.SerializeObject(subscription);
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
