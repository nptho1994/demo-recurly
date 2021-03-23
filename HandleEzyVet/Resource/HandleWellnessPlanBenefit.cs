using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Resource
{
    // Scope:   read-wellnessplabenefit
    public class HandleWellnessPlanBenefit
    {
        public string FetchWellnessPlanBenefit(string accessToken, string wellnessPlanBenefitId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v2/wellnessplanbenefit/" + wellnessPlanBenefitId);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
