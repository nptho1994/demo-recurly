using Recurly.Constants;
using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandleAccountAcquisitionInfo
    {
        public string FetchAccountAcquisitionInfo(string accountId)
        {
            try
            {
                AccountAcquisition acquisition = HandleClient.client.GetAccountAcquisition(accountId);
                return $"Fetched account acquisition {acquisition.Id}";
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

        public string UpdateAccountAcquisitionInfo(string accountId)
        {
            try
            {
                var acquisitionReq = new AccountAcquisitionUpdate()
                {
                    Campaign = "big-event-campaign",
                    Channel = Channel.SocialMedia,
                    Subchannel = "twitter"
                };
                AccountAcquisition accountAcquisition = HandleClient.client.UpdateAccountAcquisition(accountId, acquisitionReq);
                return $"Update account acquisition {accountAcquisition.Id}";
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

        internal string RemoveAccountAcquisitionInfo(string accountId)
        {
            try
            {
                HandleClient.client.RemoveAccountAcquisition(accountId);
                return $"Removed account acquisition from account {accountId}";
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

        internal string GetListAccountAcquisitionInfo()
        {
            var acquisitions = HandleClient.client.ListAccountAcquisition();
            string listAccquisition = string.Empty;
            foreach (AccountAcquisition acquisition in acquisitions)
            {
                listAccquisition += acquisition.Id + "\t";
            }
            return listAccquisition;
        }
    }
}
