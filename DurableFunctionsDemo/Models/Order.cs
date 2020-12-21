using System;
using System.Collections.Generic;
using System.Text;

namespace DurableFunctionsDemo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string productName { get; set; }
        public string OrderName { get; set; }
        public int Quantity { get; set; }
    }
}
