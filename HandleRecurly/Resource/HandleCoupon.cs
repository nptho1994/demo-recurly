﻿using HandleRecurly.Config;
using Recurly.Constants;
using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandleCoupon
    {
        public string CreateCoupon()
        {
            try
            {
                string index = DateTime.Now.ToString("MMddHHmm", CultureInfo.InvariantCulture);
                var couponReq = new CouponCreate()
                {
                    Name = "Promotional Coupon",
                    Code = "coupon" + index,
                    DiscountType = DiscountType.Fixed,
                    Currencies = new List<CouponPricing>() {
                        new CouponPricing() {
                            Currency = SettingRecurly.RECURLY_CURRENCE,
                            Discount = 1000
                        }
                    }
                };
                Coupon coupon = HandleClient.client.CreateCoupon(couponReq);
                return $"Created coupon {coupon.Id}";
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
