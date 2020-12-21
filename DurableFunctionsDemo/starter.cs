using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using DurableFunctionsDemo.Models;

namespace DurableFunctionsDemo
{
    public static class starter
    {
        [FunctionName("SubmitOrder")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [OrchestrationClient] IDurableOrchestrationClient starter,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var data = JsonConvert.DeserializeObject<Order>(requestBody);

          
            if (data is Order order)
            {
                string orchestrationId = await starter.StartNewAsync("OrderOrchestrator", order);
                return starter.CreateCheckStatusResponse(req, orchestrationId);
            }

            return new BadRequestResult();
        }
    }
}
