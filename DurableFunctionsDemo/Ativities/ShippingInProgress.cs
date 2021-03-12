using Core.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DurableFunctionsDemo.Ativities
{
    public class ShippingInProgress
    {
        private IOrderShippingDetailsService _orderShippingDetailsService;
        public ShippingInProgress(IOrderShippingDetailsService orderShippingDetailsService)
        {
            _orderShippingDetailsService = orderShippingDetailsService;
        }
        [FunctionName("OrderDelivered")]
        public  async Task<bool> Run(
         [ActivityTrigger] OrderShippingDetailsModel input,
           ILogger log)
        {
            return await _orderShippingDetailsService.addOrderShipping(input);

        }
    }
}
