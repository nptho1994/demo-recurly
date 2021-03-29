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
        public string Fetch(string accessToken, string wellnessPlanId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplan/" + wellnessPlanId);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string Create(string accessToken)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplan");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + accessToken);
			WellnessPlan wellnessPlan = new WellnessPlan();
            string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
            wellnessPlan.name = "WellnessPlan " + index;
            wellnessPlan.subscription_fee_product = 2;
			wellnessPlan.min_cycle_qty_on_signup = 1;
			wellnessPlan.cancellation_product = 2;
			wellnessPlan.ownership_id = 1;
            string contactString = JsonConvert.SerializeObject(
               wellnessPlan,
               Newtonsoft.Json.Formatting.None,
               new JsonSerializerSettings
               {
                   NullValueHandling = NullValueHandling.Ignore
                   
               }
            );
			request.AddParameter("application/json", contactString, ParameterType.RequestBody);
			IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string Update(string accessToken, string wellnessPlanId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplan/" + wellnessPlanId);
            client.Timeout = -1;
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            WellnessPlan wellnessPlan = new WellnessPlan();
            string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
            wellnessPlan.name = "Update "+index;
            wellnessPlan.discontinued = false;
            wellnessPlan.active = false;
            wellnessPlan.cancellation_product = 2;
             string contactString = JsonConvert.SerializeObject(
               wellnessPlan,
               Newtonsoft.Json.Formatting.None,
               new JsonSerializerSettings
               {
                   NullValueHandling = NullValueHandling.Ignore
               }
            );
            request.AddParameter("application/json", contactString, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string Delete(string accessToken, string wellnessPlanId)
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

