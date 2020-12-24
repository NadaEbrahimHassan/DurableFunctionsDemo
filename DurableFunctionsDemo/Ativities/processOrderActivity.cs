using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using DurableFunctionsDemo.Models;


namespace DurableFunctionsDemo
{
    public static class processOrderActivity
    {
        [FunctionName("processOrder")]
        public static async Task Run(
          [ActivityTrigger] OrderModel input, 
            ILogger log)
        {
            log.LogInformation("Process Request");
          
            log.LogInformation($"Process Request for product ");
          
        }
    }
}
