using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repos
{
   public class CourierRepository: GenericRepository<Courier>, ICourierRepository
    {
        private DbContext _context;
        public CourierRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Courier>> GetAllCouriers()
        {
            return await Get();
        }

        public Task<Courier> GetCourierById(int id)
        {
            return Get(id);
        }

        public void UpdateCourier(Courier courier)
        {
            Update(courier);
        }
    }
}
