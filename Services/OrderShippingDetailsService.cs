using AutoMapper;
using Core.Models;
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
        public OrderShippingDetailsService(UnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<bool> addOrderShipping(OrderShippingDetailsModel ordershippingDetailsModel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateOrderShipping(OrderShippingDetailsModel ordershippingDetailsModel)
        {
            throw new NotImplementedException();
        }
    }
}
