using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace DurableFunctionsDemo.Entitties
{
   public class Product: TableEntity
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
