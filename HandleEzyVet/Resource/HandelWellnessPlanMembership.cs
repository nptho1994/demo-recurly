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
        public string FetchWellnessPlanMembership(string accessToken, string wellnessPlanMembershipId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplanmembership");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddParameter("id", wellnessPlanMembershipId);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string CreateWellnessPlanMembership(string accessToken)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplanmembership");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            WellnessPlanMembershipUpdate wellnessPlanMembershipUpdate = new WellnessPlanMembershipUpdate();
            //wellnessPlanMembershipUpdate.id = Int32.Parse(wellnessPlanMembershipId);
            wellnessPlanMembershipUpdate.status = "Active";
            wellnessPlanMembershipUpdate.reference = "RefNo:124585";
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

        public string UpdateWellnessPlanMembership(string accessToken, string wellnessPlanMembershipId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplanmembership");
            client.Timeout = -1;
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            WellnessPlanMembershipUpdate wellnessPlanMembershipUpdate = new WellnessPlanMembershipUpdate();
            wellnessPlanMembershipUpdate.id = Int32.Parse(wellnessPlanMembershipId);
            wellnessPlanMembershipUpdate.status = "Active";
            wellnessPlanMembershipUpdate.reference = "RefNo:124585";
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
