using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandleSite
    {
        public List<Site> GetSiteId()
        {
            var sites = HandleClient.client.ListSites();
            List<Site> lstSite = new List<Site>();
            foreach (Site site in sites)
            {
                lstSite.Add(site);
            }
            return lstSite;
        }
    }
}
