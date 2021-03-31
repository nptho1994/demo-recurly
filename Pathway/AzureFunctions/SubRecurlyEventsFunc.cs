using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using AzureFunctions.Recurly;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctions
{
    public class SubRecurlyEventsFunc
    {
        IAuthorizationService authorizationService = new AuthorizationService();
        [FunctionName("SubRecurlyEventsFunc")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [ServiceBus("integration", Connection = "ServiceBusConnectionString")]
            IAsyncCollector<Message> outputServiceBus,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            // 1. Check header authorization: solution #D-2.1
            // TODO
            bool authorization = authorizationService.Validate(req);


             // 2. If passed authorization, get message from webhook: solution #D-2.2
             // 2.1. Deserialize body to Account and Subcriptions: solution #D-2.2
             // TODO
             // 2.3. Set subcription type for message:  solution #D-2.2
             // TODO

             //Sample:
             var body = await new StreamReader(req.Body).ReadToEndAsync();
            var message1 = new Message();
            message1.Body = Encoding.UTF8.GetBytes(body);

            message1.To = "subscription";

            // 2.4: Send to Service bus:
            await outputServiceBus.AddAsync(message1);
            return new OkObjectResult("OK");

        }
       
    }
}
