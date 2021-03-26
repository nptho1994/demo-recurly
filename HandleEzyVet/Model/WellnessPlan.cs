using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Model
{
    public class WellnessPlan
    {
        public int? id { get; set; }
        public int? created_at { get; set; }
        public int? modified_at { get; set; }
        public bool? active { get; set; }
        public string name { get; set; }
        public string subscription_cycle_unit { get; set; }
        public int? subscription_cycle_qty { get; set; }
        public int? subscription_fee_product { get; set; }
        public object fixed_subscription_price { get; set; }
        public int? min_cycle_qty_on_signup { get; set; }
        public int? term_qty { get; set; }
        public int? pause_limit_qty { get; set; }
        public int? extends_end_date { get; set; }
        public string portion_revenue_payable { get; set; }
        public object enrollment_fee_product { get; set; }
        public object replacement_wellness_plan { get; set; }
        public bool? discontinued { get; set; }
        public int? cancellation_product { get; set; }
        public bool? default_renew { get; set; }
        public object renewal_fee_product { get; set; }
        public int? ownership_id { get; set; }
    }
}
