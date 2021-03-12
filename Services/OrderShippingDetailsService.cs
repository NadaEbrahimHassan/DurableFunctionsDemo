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
  public class OrderShippingDetailsService : IOrderShippingDetailsService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public OrderShippingDetailsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> addOrderShipping(OrderShippingDetailsModel ordershippingDetailsModel)
        {
            var entity = _mapper.Map<OrderShippingDetailsModel, OrderShippingDetails>(ordershippingDetailsModel);
            _unitOfWork.OrderShippingDetails.AddOrderShippingDetails(entity);
            return (await _unitOfWork.SaveAsync()) > 0;
        }

        public async Task<bool> UpdateOrderShipping(OrderShippingDetailsModel ordershippingDetailsModel)
        {
            var entity = _mapper.Map<OrderShippingDetailsModel, OrderShippingDetails>(ordershippingDetailsModel);
            _unitOfWork.OrderShippingDetails.AddOrderShippingDetails(entity);
            return (await _unitOfWork.SaveAsync()) > 0;
        }
    }
}
