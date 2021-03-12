using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
