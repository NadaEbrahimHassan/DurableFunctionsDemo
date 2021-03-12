using AutoMapper;
using Core.Models;
using Data.Entities;
using Repositories.UnitOfWork;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CourierService : ICourierService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;

        public CourierService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<CourierModel>> GetAllCouriers()
        {
            var couriersEntities = await _unitOfWork.CourierRepository.GetAllCouriers();
            return _mapper.Map<List<Courier>, List<CourierModel>>(couriersEntities);
        }

        public async Task<List<CourierModel>> GetAvaliableCouriers()
        {
            var couriersEntities= (await _unitOfWork.CourierRepository.GetAllCouriers()).Where(c => c.IsAvaliable).ToList();
            return _mapper.Map<List<Courier>, List<CourierModel>>(couriersEntities);
        }

        public async Task<CourierModel> PickAvaliableCourier()
        {
            var entity = (await _unitOfWork.CourierRepository.GetAllCouriers()).FirstOrDefault(c => c.IsAvaliable);
            return _mapper.Map<Courier, CourierModel>(entity);
        }

        public async Task<bool> UpdateCourierAvability(int courierid, bool isAvaliable)
        {
            var courier = await _unitOfWork.CourierRepository.GetCourierById(courierid);
            courier.IsAvaliable = isAvaliable;
            _unitOfWork.CourierRepository.UpdateCourier(courier);
            return (await _unitOfWork.SaveAsync()) > 0;
        }
    }
}
