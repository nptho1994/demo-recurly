using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Model
{
    public class Appointment
    {
        public int id { get; set; }
        public int created_at { get; set; }
        public int modified_at { get; set; }
        public bool active { get; set; }
        public int start_at { get; set; }
        public int duration { get; set; }
        public int type_id { get; set; }
        public int status_id { get; set; }
        public string description { get; set; }
        public int animal_id { get; set; }
        public int consult_id { get; set; }
        public int contact_id { get; set; }
        public int sales_resource { get; set; }
        public List<Resource> resources { get; set; }
        public class Resource
        {
            public int id { get; set; }
        }
    }
}
