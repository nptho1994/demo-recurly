using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Model
{
    public class Address
    {
        //public string id { get; set; }
        //public string active { get; set; }
        //public string created_at { get; set; }
        //public string modified_at { get; set; }
        //public string name { get; set; }
        public string street_1 { get; set; }
        public string street_2 { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string post_code { get; set; }
        public string country_id { get; set; }
        public string state { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        //public ForResource for_resource { get; set; }
    }
    public class ForResource
    {
        public Contact Contact { get; set; }
    }
}
