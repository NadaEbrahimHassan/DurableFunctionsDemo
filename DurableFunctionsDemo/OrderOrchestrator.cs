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
using DurableFunctionsDemo.Entitties;

namespace DurableFunctionsDemo
{
    public static class OrderOrchestrator
    {
        [FunctionName("OrderOrchestrator")]
        public static async Task<object> Run(
            [OrchestrationTrigger] IDurableOrchestrationContext ctx,
            ILogger log)
        {
            var submittedOrder = ctx.GetInput<Order>();
          
            await ctx.CallActivityAsync("fillExistedproductsActivity", null);
            var selectedProduct = await ctx.CallActivityAsync<Product>("processOrder", submittedOrder);
            var canShipOrder = await ctx.CallActivityAsync<bool>("shipOrder", selectedProduct);

            return canShipOrder ? " Order recived " : "order canceled";
        }
    }
}
