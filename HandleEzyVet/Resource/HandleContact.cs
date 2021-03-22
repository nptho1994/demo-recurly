using HandleEzyVet.Config;
using HandleEzyVet.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Resource
{
    public class HandleContact
    {
		public string FetchContact()
        {
			var client = new RestClient("https://api.trial.ezyvet.com/v1/contact?limit=1");
			client.Timeout = -1;
			var request = new RestRequest(Method.GET);
			request.AddHeader("Content-Type", "application/merge-patch+json");
			request.AddHeader("Authorization", "Bearer 9hgjywbyqp2cW7RGp95h5B82aEZegpYdEkhA3TBX");
			IRestResponse response = client.Execute(request);
			return response.Content;
		}

        public string CreateContact()
        {
			var client = new RestClient("https://api.trial.ezyvet.com/v1/contact");
			client.Timeout = -1;
			var request = new RestRequest(Method.POST);
			request.AddHeader("Authorization", "Bearer NCn6QA4z1h7rVzkKwV87oViv4Quqi2vBfwGDsLBe");
			request.AddHeader("Content-Type", "application/json");

			Contact createContact = new Contact();
			createContact.first_name = "Nguyen";
			createContact.last_name = "Tho";
			createContact.contact_detail_list = new List<ContactDetailList>()
			{
				new ContactDetailList()
				{
					name = "Email",
					value = "phutho2614@gmail.com",
					contact_detail_type_id = 1
				},
				new ContactDetailList()
				{
					name = "Home",
					value = "0123456789",
					contact_detail_type_id = 3

				}
			};
			//createContact.address_physical = "123";
			createContact.stop_credit = "WARNING";
			string contactString = JsonConvert.SerializeObject(createContact);
			request.AddParameter("application/json", contactString, ParameterType.RequestBody);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}

		public string UpdateContactById(string id)
        {
			var client = new RestClient("https://api.trial.ezyvet.com/v1/contact/" + id);
			client.Timeout = -1;
			var request = new RestRequest(Method.PATCH);
			request.AddHeader("Content-Type", "application/merge-patch+json");
			request.AddHeader("Authorization", "Bearer YgNFogYK257bUxmGdPo6kg5v408yyGRVMH0CSpIB");
			Contact createContact = new Contact();
			createContact.first_name = "NguyenTest";
			createContact.last_name = "ThoTest";
			createContact.address_physical = new Address()
			{
				street_1 = "street1",
				street_2 = "street2",
				suburb = "suburd",
				city = "city",
				region = "region",
				post_code = "postcode",
				country_id = "country",
				state = "state",
				latitude = "30",
				longitude = "10"
			};
			createContact.contact_detail_list = new List<ContactDetailList>()
			{
				new ContactDetailList()
				{
					name = "Demo Email",
					value = "demo@demo.com",
					contact_detail_type_id = 1
				}
			};
			createContact.stop_credit = "OK";
			string contactString = JsonConvert.SerializeObject(createContact);
			request.AddParameter("application/json", contactString, ParameterType.RequestBody);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}

		public string DeleteContactById(string id)
        {
			var client = new RestClient("https://api.trial.ezyvet.com/v1/contact/19206");
			client.Timeout = -1;
			var request = new RestRequest(Method.DELETE);
			request.AddHeader("Authorization", "Bearer NCn6QA4z1h7rVzkKwV87oViv4Quqi2vBfwGDsLBe");
			IRestResponse response = client.Execute(request);
			return response.Content;
		}
    }
}
