using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Resource
{
	public class FetchDataEzyVet
    {
		public string FetchUser(string accessToken, string Id)
		{
			var client = new RestClient("https://api.trial.ezyvet.com/v1/user");
			client.Timeout = -1;
			var request = new RestRequest(Method.GET);
			if (!string.IsNullOrWhiteSpace(Id)) request.AddParameter("id", Id);
			request.AddParameter("limit", 200);
			request.AddParameter("name", "Jonathan Kilgus (Head Office) CS");
			request.AddHeader("Authorization", "Bearer " + accessToken);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}

		public string FetchResource(string accessToken, string Id, string ownership_id)
		{
			var client = new RestClient("https://api.trial.ezyvet.com/v1/resource");
			client.Timeout = -1;
			var request = new RestRequest(Method.GET);
			if (!string.IsNullOrWhiteSpace(Id)) request.AddParameter("id", Id);
			if (!string.IsNullOrWhiteSpace(ownership_id))  request.AddParameter("ownership_id", ownership_id);	
			request.AddParameter("limit", 200);
			request.AddHeader("Authorization", "Bearer " + accessToken);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}

		public string FetchSeparation(string accessToken, string Id)
		{
			var client = new RestClient("https://api.trial.ezyvet.com/v1/separation");
			client.Timeout = -1;
			var request = new RestRequest(Method.GET);
			if (!string.IsNullOrWhiteSpace(Id)) request.AddParameter("id", Id);
			request.AddParameter("limit", 100);
			request.AddHeader("Authorization", "Bearer " + accessToken);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}
	}
}
