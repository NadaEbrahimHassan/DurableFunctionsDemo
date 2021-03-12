using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using DurableFunctionsDemo.Models;
using Services.Interfaces;

namespace DurableFunctionsDemo
{
    public class processOrderActivity
    {
        private IOrderService _orderService;
        public processOrderActivity(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [FunctionName("processOrder")]
        public  async Task Run(
          [ActivityTrigger] OrderModel input, 
            ILogger log)
        {
            log.LogInformation("Process Request");
           await _orderService.AddNewOrder(null);
            log.LogInformation($"Process Request for product ");
          
        }
    }
}
