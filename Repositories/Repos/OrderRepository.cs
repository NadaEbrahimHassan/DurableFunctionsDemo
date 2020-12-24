using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repos
{
    public class OrderRepository:GenericRepository<Order>,IOrderRepository
    {
        private DbContext _context;
        public OrderRepository(DbContext context):base(context)
        {
            _context = context;
        }

        public void AddOrder(Order order)
        {
            Add(order);
        }
    }
}
