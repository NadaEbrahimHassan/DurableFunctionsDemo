using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IProductRepository _productRepository;
        private IOrderRepository _orderRepository;
        private ICourierRepository _courierRepository;
        private IOrderShippingDetails _orderShippingDetails;
        private DbContext _context;

        public UnitOfWork(IProductRepository productRepository, IOrderRepository orderRepository,
            ICourierRepository courierRepository, IOrderShippingDetails orderShippingDetails, DbContext context)
        {
            _context = context;
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _courierRepository = courierRepository;
            _orderShippingDetails = orderShippingDetails;

        }
        public IProductRepository ProductRepository => _productRepository;

        public IOrderRepository OrderRepository => _orderRepository;

        public ICourierRepository CourierRepository => _courierRepository;

        public IOrderShippingDetails OrderShippingDetails => _orderShippingDetails;

        public void save()
        {
            _context.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
           return await _context.SaveChangesAsync();
        }
    }
}
