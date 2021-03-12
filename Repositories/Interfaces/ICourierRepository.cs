using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
   public interface ICourierRepository
    {
        Task<List<Courier>> GetAllCouriers();
        Task<Courier> GetCourierById(int id);
        void UpdateCourier(Courier courier);
    }
}
