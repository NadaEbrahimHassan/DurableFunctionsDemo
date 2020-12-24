using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repos
{
    class CourierRepository: GenericRepository<Courier>, ICourierRepository
    {
        private DbContext _context;
        public CourierRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public void UpdateCourier(Courier courier)
        {
            Update(courier);
        }
    }
}
