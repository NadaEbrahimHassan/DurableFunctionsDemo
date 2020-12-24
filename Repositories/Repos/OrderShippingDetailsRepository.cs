using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repos
{
    public class OrderShippingDetailsRepository: GenericRepository<OrderShippingDetails>, IOrderShippingDetails
    {
        private DbContext _context;
        public OrderShippingDetailsRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public void AddOrderShippingDetails(OrderShippingDetails orderShippingDetails)
        {
            Add(orderShippingDetails);
        }

        public void UpdateOrderShipping(OrderShippingDetails orderShippingDetails)
        {
            Update(orderShippingDetails);
        }
    }
}
