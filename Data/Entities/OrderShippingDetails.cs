using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entities
{
   public class OrderShippingDetails
    {
        public int CourierId { get; set; }
        public int OrderId { get; set; }
        public bool IsDelivered { get; set; }

        public Courier Courier { get; set; }
        public Order Order { get; set; }
    }
}
