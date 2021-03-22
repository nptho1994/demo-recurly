using HandleEzyVet.Config;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Resource
{
    public class HandleConnection
    {
        public string GetAccessTokenByScope(string scope)
        {
            var client = new RestClient(ClientConfig.EZYVET_URL_GETTOKEN);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", ClientConfig.EZYVET_HEADER_CONTENT_TYPE);
            request.AddParameter("partner_id", ClientConfig.EZYVET_PARTNER_ID);
            request.AddParameter("client_id", ClientConfig.EZYVET_CLIENT_ID);
            request.AddParameter("client_secret", ClientConfig.EZYVET_CLIENT_SECRET);
            request.AddParameter("grant_type", ClientConfig.EZYVET_GRANT_TYPE);
            request.AddParameter("scope", scope);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
