using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quntity { get; set; }

        public Product Product { get; set; }
    }
}
