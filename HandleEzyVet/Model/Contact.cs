using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Model
{
    public class Contact
    {
        //public string id { get; set; }
        //public string active { get; set; }
        //public string created_at { get; set; }
        //public string modified_at { get; set; }
        //public string code { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        //public string business_name { get; set; }
        //public string is_business { get; set; }
        //public string is_customer { get; set; }
        //public string is_supplier { get; set; }
        //public string is_vet { get; set; }
        //public string is_syndicate { get; set; }
        //public string is_staff_member { get; set; }
        public string stop_credit { get; set; }
        public List<ContactDetailList> contact_detail_list { get; set; }
        public Address address_physical { get; set; }
        //public string address_postal { get; set; }
        //public string ownership_id { get; set; }
    }

    public class ContactDetailList
    {
        public string name { get; set; }
        public string value { get; set; }
        public int contact_detail_type_id { get; set; }
    }
}
