using System;
using System.Collections.Generic;
using System.Text;

namespace HandleRecurly.Config
{
    public static class SettingRecurly
    {
        // Setting trial
        public static string RECURLY_PUBLIC_APIKEY = "ewr1-goiv5nUv4jGq8RiVtd30Gh";
        public static string RECURLY_PRIVATE_APIKEY = "9dc6a29a7a6443fbbb3ebd5662907c2f";
        public static string RECURLY_SITE = "thonguyen261";
        public static string RECURLY_GETTOKEN_API = "https://api.recurly.com/js/v1/token";
        public static string RECURLY_CURRENCE = "VND";

        // Setting production
        //public static string RECURLY_PUBLIC_APIKEY = "ewr1-UUmB1cJRV29CS7F1ltGPaV";
        //public static string RECURLY_PRIVATE_APIKEY = "bc1906867e2945bdb3300ae35fd8a9fd";
        //public static string RECURLY_SITE = "healthpetmembership";
        //public static string RECURLY_GETTOKEN_API = "https://api.recurly.com/js/v1/token";
        //public static string RECURLY_CURRENCE = "USD";

        // Ezyvet
        public static string EZYVET_URL_GETTOKEN = "https://api.trial.ezyvet.com/v1/oauth/access_token";
        public static string EZYVET_HEADER_CONTENT_TYPE = "application/x-www-form-urlencoded";
        public static string EZYVET_URL_API = "https://api.trial.ezyvet.com/v1";
        public static string EZYVET_PARTNER_ID = "4f91ed9c04199439d72cc23c4f88b5428f907bb4dd96191f91702749324af09e";
        public static string EZYVET_CLIENT_ID = "efb322a7cd1ab342e6ea30b2af8c0399";
        public static string EZYVET_CLIENT_SECRET = "$2y$10$Fqa0d8UhYkAJL2V16OqqqOPpvhj0Gah24r0M7dR8FPho7mc3OEpBi";
        public static string EZYVET_GRANT_TYPE = "client_credentials";


    }
}
