using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Services.Interfaces;
using DurableFunctionsDemo.Models;
using Core.Models;

namespace DurableFunctionsDemo
{
    public  class ShipOrderActivity
    {

        private ICourierService _courierService;
        public ShipOrderActivity(ICourierService courierService)
        {
            _courierService = courierService;
        }

        [FunctionName("processShipping")]
        public  async Task<CourierModel> Run(
        [ActivityTrigger] object input,
           ILogger log)
        {
            var courier= await _courierService.PickAvaliableCourier();
            if (courier!= null)
                await _courierService.UpdateCourierAvability(courier.Id, true);

            return courier;
        }
    }
}
