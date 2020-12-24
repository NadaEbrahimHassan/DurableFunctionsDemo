using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using DurableFunctionsDemo.Models;


namespace DurableFunctionsDemo
{
    public static class OrderOrchestrator
    {
        [FunctionName("OrderOrchestrator")]
        public static async Task<object> Run(
            [OrchestrationTrigger] IDurableOrchestrationContext ctx,
            ILogger log)
        {
            var submittedOrder = ctx.GetInput<OrderModel>();

            //var selectedProduct = await ctx.CallActivityAsync("processOrder", submittedOrder);
            //var canShipOrder = await ctx.CallActivityAsync<bool>("shipOrder", selectedProduct);

            //  return canShipOrder ? " Order recived " : "order canceled";
            return null;
        }
    }
}
