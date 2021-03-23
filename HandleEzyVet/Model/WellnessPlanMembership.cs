using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Model
{
    public class WellnessPlanMembership
    {
    }

    public class WellnessPlanMembershipUpdate
    {
        public int id { get; set; }
        public string status { get; set; }
        public string cancellation_option { get; set; }
        public double cancellation_fee { get; set; }
        public string reference { get; set; }
    }

    public class WellnessPlanMembershipCreate
    {
        public int start_date { get; set; }
        public int animal_id { get; set; }
        public int renew_when_expired { get; set; }
        public int billing_interval { get; set; }
        public int resource_id { get; set; }
        public int wellness_plan { get; set; }
        public int next_wellness_plan { get; set; }
        public string reference { get; set; }
        public int ownership_id { get; set; }
    }
}
