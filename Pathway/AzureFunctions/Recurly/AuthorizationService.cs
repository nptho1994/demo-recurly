using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunctions.Recurly
{
    class AuthorizationService : IAuthorizationService
    {
        public bool Validate(HttpRequest request)
        {
            bool result = false;
            // Getting value from Headers["Authorization"] from request.

            var tokenId = System.Environment.GetEnvironmentVariable("AccessToken", EnvironmentVariableTarget.Process);
            //Encode username/ password in settings with Base 64.
            //Compare above with Headers["Authorization"]
            return result;
        }
    }
}
