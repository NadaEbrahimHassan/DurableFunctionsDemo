using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;

namespace DurableFunctionsDemo
{
    public static class ShipOrderActivity
    {

        [FunctionName("shipOrder")]
        public static async Task<bool> Run(
        [ActivityTrigger] object product,
           ILogger log)
        {

            if (product== null)
            {
               
                log.LogInformation("canceled");
                return false;
            }
            else
            {
                log.LogInformation("shipping in progess");
                return true;
            }
          
        }
    }
}
