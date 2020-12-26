using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
   public interface IOrderShippingDetails
    {
         void AddOrderShippingDetails(OrderShippingDetails orderShippingDetails);
         void UpdateOrderShipping(OrderShippingDetails orderShippingDetails);
    }
}
