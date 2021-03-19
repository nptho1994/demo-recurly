using HandleRecurly.Config;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandleBillingInfo
    {
        public string GetBillingInfoToken()
        {
            CheckFunction checkFunction = new CheckFunction();
            return checkFunction.CallApiGetTokenBillingInfo();
        }
    }
}
