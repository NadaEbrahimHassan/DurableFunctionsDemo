using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using DurableFunctionsDemo.Models;
using Core.Models;

namespace DurableFunctionsDemo
{
    public static class OrderOrchestrator
    {
        [FunctionName("OrderOrchestrator")]
        public static async Task<object> Run(
            [OrchestrationTrigger] IDurableOrchestrationContext ctx,
            ILogger log)
        {
            var submittedOrder = ctx.GetInput<Core.Models.OrderModel>();

           var result= await ctx.CallActivityAsync<(bool,int)>("processOrder", submittedOrder);
            if (!result.Item1)
            {
                log.LogInformation("sorry this product is out of the stock :( ");
                return null;
            }

            var avaliableCourier = await ctx.CallActivityAsync<CourierModel>("processShipping", submittedOrder);

            if (avaliableCourier == null)
            {
                log.LogInformation("sorry there is no courier to ship your order :( ");
                return null;
            }

            //await ctx.CallActivityAsync<bool>("ShippingInProgress", new OrderShippingDetailsModel() {CourierId= avaliableCourier.Id,OrderId });

            var isApproved = await ctx.WaitForExternalEvent<bool>("ShippingInProgress");

            await ctx.CallActivityAsync<bool>("OrderDelivered", new OrderShippingDetailsModel() {CourierId= avaliableCourier.Id,OrderId=result.Item2 ,IsDelivered=isApproved});
            return null;
        }
    }
}
