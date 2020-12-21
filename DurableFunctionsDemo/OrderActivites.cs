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
using Microsoft.Azure.Cosmos.Table;
using DurableFunctionsDemo.Entitties;
using System.Linq;

namespace DurableFunctionsDemo
{
    public static class OrderActivites
    {
        [FunctionName("processOrder")]
        public static async Task<Product> Run(
          [Table("products", Connection = "AzureWebJobsStorage")] CloudTable productTable,
          [ActivityTrigger] Order input, 
            ILogger log)
        {
            log.LogInformation("Process Request");
            var query = new TableQuery<Product>();
            var segment = await productTable.ExecuteQuerySegmentedAsync(query,null);
            var selectedProduct = segment.Results.Find(p => p.Name == input.productName && p.Quantity >= input.Quantity);
            log.LogInformation($"Process Request for product {selectedProduct?.Name}");
            return selectedProduct;
        }
    }
}
