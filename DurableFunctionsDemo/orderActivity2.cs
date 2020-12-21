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
using DurableFunctionsDemo.Entitties;

namespace DurableFunctionsDemo
{
    public static class orderActivity2
    {

        [FunctionName("shipOrder")]
        public static async Task<bool> Run(
        [ActivityTrigger] Product product,
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
