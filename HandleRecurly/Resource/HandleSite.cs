using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandleSite
    {
        public string GetSiteBySub(string subDomain)
        {
            var sites = HandleClient.client.ListSites();
            foreach (Site site in sites)
            {
                if (site.Subdomain == subDomain)
                    return site.Id;
            }
            return string.Empty;
        }
    }
}
