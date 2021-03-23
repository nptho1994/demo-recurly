using HandleEzyVet.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Resource
{
    // Scope:   read-wellnessplan
    //          write-wellnessplan
    public class HandleWellnessPlan
    {
        public string FetchWellnessPlan(string accessToken, string wellnessPlanId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplan/" + wellnessPlanId);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string CreateWellnessPlan(string accessToken)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplan");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + accessToken);
			WellnessPlanCreate wellnessPlan = new WellnessPlanCreate();
            string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
            wellnessPlan.name = "Demo" + index;
            wellnessPlan.subscription_fee_product = 2;
			wellnessPlan.min_cycle_qty_on_signup = 1;
			wellnessPlan.cancellation_product = 2;
			wellnessPlan.ownership_id = 1;
            string contactString = JsonConvert.SerializeObject(wellnessPlan);
			request.AddParameter("application/json", contactString, ParameterType.RequestBody);
			IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string UpdateWellnessPlan(string accessToken, string wellnessPlanId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplan/" + wellnessPlanId);
            client.Timeout = -1;
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            WellnessPlanUpdate wellnessPlan = new WellnessPlanUpdate();
            string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
            wellnessPlan.name = "test"+index;
            string contactString = JsonConvert.SerializeObject(wellnessPlan);
            request.AddParameter("application/json", contactString, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string DeleteWellnessPlan(string accessToken, string wellnessPlanId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplan/" + wellnessPlanId);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }       
    }
}

