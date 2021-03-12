using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface IOrderService
    {
        Task<bool> AddNewOrder(OrderModel orderModel);
        Task<OrderModel> AddNewOrderWithIdentity(OrderModel orderModel);
    }
}
