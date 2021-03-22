using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Model
{
    public class WellnessPlanCreate
    {
        public string name { get; set; }
        public int subscription_fee_product { get; set; }
        public int min_cycle_qty_on_signup { get; set; }
        public int cancellation_product { get; set; }
        public int ownership_id { get; set; }
    }

    public class WellnessPlanUpdate
    {
        public string name { get; set; }
    }
}
