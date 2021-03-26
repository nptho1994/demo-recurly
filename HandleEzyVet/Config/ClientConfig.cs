using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEzyVet.Config
{
    public static class ClientConfig
    {
        public static string EZYVET_URL_GETTOKEN = "https://api.trial.ezyvet.com/v1/oauth/access_token";
        public static string EZYVET_HEADER_CONTENT_TYPE = "application/x-www-form-urlencoded";
        public static string EZYVET_URL_API = "https://api.trial.ezyvet.com/v1";
        public static string EZYVET_PARTNER_ID = "4f91ed9c04199439d72cc23c4f88b5428f907bb4dd96191f91702749324af09e";
        public static string EZYVET_CLIENT_ID = "efb322a7cd1ab342e6ea30b2af8c0399";
        public static string EZYVET_CLIENT_SECRET = "$2y$10$Fqa0d8UhYkAJL2V16OqqqOPpvhj0Gah24r0M7dR8FPho7mc3OEpBi";
        public static string EZYVET_GRANT_TYPE = "client_credentials";
    }
}
