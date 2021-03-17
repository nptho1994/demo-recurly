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
        public string CreatePlan()
        {
            try
            {
                string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
                var planReq = new PlanCreate()
                {
                    Name = "plan" + index,
                    Code = "plan" + index,
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
    }
}
