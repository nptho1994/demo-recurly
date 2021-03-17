using HandleRecurly.Config;
using Recurly;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandleRecurly.Resource
{
    public static class HandleClient
    {
        public static Client client = new Client(SettingRecurly.RECURLY_PRIVATE_APIKEY);
    }
}
