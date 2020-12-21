using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;
using DurableFunctionsDemo.Entitties;
using Microsoft.Azure.WebJobs;
using System.Collections.Generic;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.Cosmos.Table;

namespace DurableFunctionsDemo
{
    public static class fillExistedproductsActivity
    {
        [FunctionName("fillExistedproductsActivity")]
        public static async Task Run(
           [Microsoft.Azure.WebJobs.Table("products", Connection = "AzureWebJobsStorage")] IAsyncCollector<Product> productsTable,
            [Microsoft.Azure.WebJobs.Table("products", Connection = "AzureWebJobsStorage")] CloudTable productTable,
             [ActivityTrigger] object input,
            ILogger log)
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    PartitionKey="product",
                    Name="product 1",
                    Quantity=2,
                    RowKey="1"
                },
                new Product()
                {
                    PartitionKey="product",
                    Name="product 2",
                    Quantity=0,
                     RowKey="2"
                },
                new Product()
                {
                    PartitionKey="product",
                    Name ="product 3",
                    Quantity=3,
                     RowKey="3"
                }
            };

            var segment = await productTable.ExecuteQuerySegmentedAsync(new TableQuery(), null);

            if (segment.Results.Count==0)
            {
                foreach (var product in products)
                {
                    await productsTable.AddAsync(product);
                }
            }
        }
    }
}
