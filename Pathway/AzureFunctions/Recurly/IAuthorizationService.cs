using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunctions.Recurly
{
    interface IAuthorizationService
    {
        bool Validate(HttpRequest req);
    }
}
