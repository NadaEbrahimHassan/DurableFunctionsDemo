using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface IOrderShippingDetailsService
    {
        Task<bool> addOrderShipping(OrderShippingDetailsModel ordershippingDetailsModel);
        Task<bool> UpdateOrderShipping(OrderShippingDetailsModel ordershippingDetailsModel);
    }
}
