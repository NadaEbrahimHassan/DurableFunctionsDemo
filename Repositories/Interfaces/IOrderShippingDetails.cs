using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
   public interface IOrderShippingDetails
    {
        public void AddOrderShippingDetails(OrderShippingDetails orderShippingDetails);
        public void UpdateOrderShipping(OrderShippingDetails orderShippingDetails);
    }
}
