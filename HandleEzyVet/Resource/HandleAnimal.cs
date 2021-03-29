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
    public class HandleAnimal
    {
        public string Fetch(string accessToken, string Id)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v1/animal");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            if (!string.IsNullOrWhiteSpace(Id)) request.AddParameter("id", Id);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string Create(string accessToken, string contactId)
        {
			var client = new RestClient("https://api.trial.ezyvet.com/v1/animal");
			client.Timeout = -1;
			var request = new RestRequest(Method.POST);
			request.AddHeader("Authorization", "Bearer " + accessToken);
			request.AddHeader("Content-Type", "application/json");

            string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
            Animal animal = new Animal();
            animal.contact_id = contactId;
            animal.name = "Animal " + index;
            animal.sex_id = "1";
            animal.animalcolour_id = "1";
            animal.species_id = "1";
            animal.breed_id = "20";
            animal.weight = "10";
            animal.weight_unit="lb";
            animal.resuscitate = "3";
            animal.notes = "Demo notes";
            animal.notes_important = "1";
            string contactString = JsonConvert.SerializeObject(
               animal,
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

        public string Update(string accessToken, string animalId)
        {
            var client = new RestClient("https://api.trial.ezyvet.com/v1/animal/" + animalId);
            client.Timeout = -1;
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/merge-patch+json");
            Animal animal = new Animal();
            animal.weight = "12";
            string contactString = JsonConvert.SerializeObject(
               animal,
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

        public string Delete()
        {
            return string.Empty;
        }
    }
}
