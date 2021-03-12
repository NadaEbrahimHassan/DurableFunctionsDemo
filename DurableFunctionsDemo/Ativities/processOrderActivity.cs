using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Services.Interfaces;
using Core.Models;

namespace DurableFunctionsDemo
{
    public class processOrderActivity
    {
        private IOrderService _orderService;
        private IProductService _productService;
        public processOrderActivity(IOrderService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
        }

        [FunctionName("processOrder")]
        public async Task<(bool isProductExist, int orderID)> Run(
          [ActivityTrigger] OrderModel input,
            ILogger log)
        {
            log.LogInformation("Process Request");
            var productQty = await _productService.GetProductQuntity(input.ProductId);

            if (productQty == 0 || productQty < input.Quantity) return (false, 0);

            var addedOrder = await _orderService.AddNewOrderWithIdentity(input);
            if (addedOrder != null)
            {
                log.LogInformation($"order added sucessfully ");
                return (true,addedOrder.Id);
            }

            return (false,0);

        }
    }
}
