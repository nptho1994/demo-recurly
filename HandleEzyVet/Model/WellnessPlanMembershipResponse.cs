using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Model
{
    public class Meta
    {
        public int? items_page { get; set; }
        public int? items_page_total { get; set; }
        public int? items_page_size { get; set; }
        public int? items_total { get; set; }
        public string transaction_id { get; set; }
        public int? timestamp { get; set; }
    }

    public class Wellnessplanmembership
    {
        public int? id { get; set; }
        public int? created_at { get; set; }
        public int? modified_at { get; set; }
        public bool active { get; set; }
        public int? wellness_plan { get; set; }
        public int? animal_id { get; set; }
        public bool renew_when_expired { get; set; }
        public long? start_date { get; set; }
        public int? end_date { get; set; }
        public string status { get; set; }
        public int? billing_interval { get; set; }
        public int? resource_id { get; set; }
        public object previous_wellness_plan_membership { get; set; }
        public int? next_wellness_plan { get; set; }
        public string reference { get; set; }
        public int? ownership_id { get; set; }
    }

    public class Item
    {
        public Wellnessplanmembership wellnessplanmembership { get; set; }
    }

    public class WellnessPlanMembershipResponse
    {
        public Meta meta { get; set; }
        public List<Item> items { get; set; }
        public List<object> messages { get; set; }
    }
}
