using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
  public  class OrderShippingDetailsModel
    {
        public int CourierId { get; set; }
        public int OrderId { get; set; }
        public bool IsDelivered { get; set; }
    }
}
