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
    public class CourierService : ICourierService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public CourierService(UnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<List<CourierModel>> GetAllCouriers()
        {
            throw new NotImplementedException();
        }

        public Task<List<CourierModel>> GetAvaliableCouriers()
        {
            throw new NotImplementedException();
        }

        public Task<CourierModel> PickAvaliableCourier()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCourierAvability(int courierid, bool isAvaliable)
        {
            throw new NotImplementedException();
        }
    }
}
