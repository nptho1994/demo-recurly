using HandleEzyVet.Config;
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
    // Scope:   read-wellnessplanmembership
    //          write-wellnessplanmembership
    public class HandelWellnessPlanMembership
    {
        public string Fetch(string accessToken, string wellnessPlanId, string wellnessPlanMembershipId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplanmembership");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            if (!string.IsNullOrWhiteSpace(wellnessPlanId)) request.AddParameter("wellness_plan", wellnessPlanId);
            if (!string.IsNullOrWhiteSpace(wellnessPlanMembershipId)) request.AddParameter("id", wellnessPlanMembershipId);
            IRestResponse response = client.Execute(request);
            WellnessPlanMembershipResponse wellnessPlanMemberships = JsonConvert.DeserializeObject<WellnessPlanMembershipResponse>(response.Content);

            if (wellnessPlanMemberships.items.Count > 1)
            {
                string result = string.Empty;
                foreach (var item in wellnessPlanMemberships.items)
                {
                    result += item.wellnessplanmembership.id.ToString() + "\t";
                }
                return result;
            }
            return response.Content;
        }

        public string Create(string accessToken, string wellnessPlanId, string animalId, string resourceId, string ownershipId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplanmembership");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
            
            Wellnessplanmembership wellnessPlanMembership = new Wellnessplanmembership();
            wellnessPlanMembership.reference = "wellnessPlanMembership " + index;
            wellnessPlanMembership.billing_interval = 1;
            wellnessPlanMembership.start_date = ClientConfig.MillisecondsTimestamp(DateTime.Now);

            wellnessPlanMembership.animal_id = Int32.Parse(animalId);
            wellnessPlanMembership.wellness_plan = Int32.Parse(wellnessPlanId);
            wellnessPlanMembership.resource_id = Int32.Parse(resourceId);
            wellnessPlanMembership.ownership_id = Int32.Parse(ownershipId);

            string contactString = JsonConvert.SerializeObject(
                wellnessPlanMembership,
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

        public string Update(string accessToken, string wellnessPlanMembershipId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplanmembership");
            client.Timeout = -1;
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            Wellnessplanmembership wellnessPlanMembershipUpdate = new Wellnessplanmembership();
            wellnessPlanMembershipUpdate.id = Int32.Parse(wellnessPlanMembershipId);
            wellnessPlanMembershipUpdate.status = "Active";
            wellnessPlanMembershipUpdate.active = true;
            //wellnessPlanMembershipUpdate.ownership_id = 1;
            //wellnessPlanMembershipUpdate.reference = "RefNo:124585";
            string contactString = JsonConvert.SerializeObject(
                wellnessPlanMembershipUpdate,
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
    }
}
