using System;
using System.Collections.Generic;
using System.Text;

namespace DurableFunctionsDemo.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int productId { get; set; }
        public int Quantity { get; set; }
    }
}
