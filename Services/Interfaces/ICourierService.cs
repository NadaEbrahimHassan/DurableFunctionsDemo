using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface ICourierService
    {
        Task<List<CourierModel>> GetAllCouriers();
        Task<List<CourierModel>> GetAvaliableCouriers();
        Task<CourierModel> PickAvaliableCourier();
        Task<bool> UpdateCourierAvability(int courierid, bool isAvaliable);

    }
}
