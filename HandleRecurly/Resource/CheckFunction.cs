using HandleRecurly.Config;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandleRecurly.Resource
{
    public class CheckFunction
    {
        public bool CheckDuplicateElement(List<string> listString)
        {
            var duplicateItems = listString.GroupBy(x => x).Where(x => x.Count() > 1).ToList();
            return duplicateItems.Count() == 0;
        }

        public string CallApiGetTokenBillingInfo()
        {
            var client = new RestClient(SettingRecurly.RECURLY_GETTOKEN_API);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddParameter("first_name", "Nguyen");
            request.AddParameter("last_name", "Tho317");
            request.AddParameter("postal_code", "70115");
            request.AddParameter("address1", "900 Camp St.");
            request.AddParameter("New Orleans", "Louisiana");
            request.AddParameter("country", "United States");
            request.AddParameter("number", "4111111111111111");
            request.AddParameter("month", "12");
            request.AddParameter("year", "2040");
            request.AddParameter("cvv", "123");
            request.AddParameter("key", SettingRecurly.RECURLY_PUBLIC_APIKEY);
            request.AddParameter("city", "New Orleans");
            request.AddParameter("state", "Louisiana");
            IRestResponse response = client.Execute(request);
            BillingToken billingToken = JsonConvert.DeserializeObject<BillingToken>(response.Content);
            return billingToken.id;
        }

        public string GetAccessTokenByScope(string scope)
        {
            var client = new RestClient(SettingRecurly.EZYVET_URL_GETTOKEN);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", SettingRecurly.EZYVET_HEADER_CONTENT_TYPE);
            request.AddParameter("partner_id", SettingRecurly.EZYVET_PARTNER_ID);
            request.AddParameter("client_id", SettingRecurly.EZYVET_CLIENT_ID);
            request.AddParameter("client_secret", SettingRecurly.EZYVET_CLIENT_SECRET);
            request.AddParameter("grant_type", SettingRecurly.EZYVET_GRANT_TYPE);
            request.AddParameter("scope", scope);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string GetContact()
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v1/contact");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer aqmUbjoFgEdx4h2tjOHKqAbaJe2lyEl4ktacIAMg");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

    }
}
