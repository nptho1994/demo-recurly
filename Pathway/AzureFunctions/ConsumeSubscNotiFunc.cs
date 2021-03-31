using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace AzureFunctions
{
    public static class ConsumeSubscNotiFunc
    {
        [FunctionName("ConsumeSubscNotiFunc")]
        public static void Run([ServiceBusTrigger("integration", "subscription-sub", Connection = "ServiceBusConnectionString")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
            // E-2.2 Implement sending Message to Subscription Rest API
            // TODO
        }
    }
}