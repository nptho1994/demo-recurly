using HandleRecurly.Config;
using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandlePlan
    {
        public string CreatePlan(string planCode)
        {
            try
            {
                string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
                if (string.IsNullOrWhiteSpace(planCode)) planCode = "plan" + index;                
                var planReq = new PlanCreate()
                {
                    Name = "plan" + index,
                    Code = planCode,
                    Currencies = new List<PlanPricing>() {
                    new PlanPricing() {
                        Currency = SettingRecurly.RECURLY_CURRENCE,
                        UnitAmount = 10000
                    }
                }
                };
                Plan plan = HandleClient.client.CreatePlan(planReq);
                return $"Created plan {plan.Code}";
            }
            catch (Recurly.Errors.Validation ex)
            {
                // If the request was not valid, you may want to tell your user
                // why. You can find the invalid params and reasons in ex.Error.Params
                return $"Failed validation: {ex.Error.Message}";
            }
            catch (Recurly.Errors.ApiError ex)
            {
                // Use ApiError to catch a generic error from the API
                return $"Unexpected Recurly Error: {ex.Error.Message}";
            }

        }

        public string GetPlanIdByCode(string planCode)
        {
            var plans = HandleClient.client.ListPlans();
            foreach (Plan plan in plans)
            {
                if (planCode == plan.Code)
                    return plan.Id;
            }
            return string.Empty;
        }
    }
}
