using HandleEzyVet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Resource
{
    public class CheckFunction
    {
        string connectString = System.Configuration.ConfigurationManager
            .ConnectionStrings["SQLServer.Properties.Settings.LinqToSQLConnectionString"]
            .ConnectionString.ToString();
        public string GetTokenByCode(string scope)
        {
            EzyVetDataContextDataContext db = new EzyVetDataContextDataContext(connectString);
            List<EzyVetConfig> list = db.GetTable<EzyVetConfig>().ToList();
            foreach (var item in list)
            {
                if (item.Name == scope && !string.IsNullOrWhiteSpace(item.Value))
                    return item.Value;

            }
            return string.Empty;
        }

        public string InsertScope(string scope, string token)
        {
            try
            {
                EzyVetDataContextDataContext db = new EzyVetDataContextDataContext(connectString);
                EzyVetConfig ezyVetConfig = new EzyVetConfig()
                {
                    Name = scope,
                    Value = token
                };
                db.GetTable<EzyVetConfig>().InsertOnSubmit(ezyVetConfig);
                db.SubmitChanges();
                return "Insert new scope";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
           
        }
    }
}
