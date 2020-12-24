using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
   public interface IOrderRepository
    {
        public void AddOrder(Order order);
    }
}
