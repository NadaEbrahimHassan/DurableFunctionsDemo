using AutoMapper;
using Core.Models;
using Data.Entities;
using Repositories.UnitOfWork;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OrderService : IOrderService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> AddNewOrder(OrderModel orderModel)
        {
            var entity = _mapper.Map<OrderModel, Order>(orderModel);
           _unitOfWork.OrderRepository.AddOrder(entity);
            return (await _unitOfWork.SaveAsync()) > 0;
        }

        public async Task<OrderModel> AddNewOrderWithIdentity(OrderModel orderModel)
        {
            var entity = _mapper.Map<OrderModel, Order>(orderModel);
            _unitOfWork.OrderRepository.AddOrder(entity);
            await _unitOfWork.SaveAsync();
            return _mapper.Map<Order,OrderModel>(entity);
        }
    }
}
