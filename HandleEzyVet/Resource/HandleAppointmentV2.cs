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
    public class HandleAppointmentV2
    {
		public string Fetch(string accessToken, string Id, string resourceId)
		{
			var client = new RestClient("https://api.trial.ezyvet.com/v1/appointment");
			client.Timeout = -1;
			var request = new RestRequest(Method.GET);
			if (!string.IsNullOrWhiteSpace(Id)) request.AddParameter("id", Id);
			if (!string.IsNullOrWhiteSpace(resourceId)) request.AddParameter("sales_resource", resourceId);
			request.AddHeader("Authorization", "Bearer " + accessToken);
			IRestResponse response = client.Execute(request);
			return response.Content;
		}

		public string Create(string accessToken, string animal_id, string contact_id, string sales_resource, string consult_id)
		{
			var client = new RestClient("https://api.trial.ezyvet.com/v1/appointment");
			client.Timeout = -1;
			var request = new RestRequest(Method.GET);
			request.AddHeader("Authorization", "Bearer " + accessToken);
			string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
			Appointment appointment = new Appointment();
			appointment.start_at = 1565584420;
			appointment.duration = 2400;
			appointment.type_id = 51;
			appointment.status_id = 1;
			appointment.description = "12312312";
			appointment.animal_id = Int32.Parse(animal_id);
			appointment.consult_id = Int32.Parse(consult_id);
			appointment.sales_resource = Int32.Parse(sales_resource);
			appointment.contact_id = Int32.Parse(contact_id);
			string contactString = JsonConvert.SerializeObject(
			   appointment,
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
