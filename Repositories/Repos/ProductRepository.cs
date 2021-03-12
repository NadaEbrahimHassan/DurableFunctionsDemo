using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repos
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private DbContext _context;
        public ProductRepository(DbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await Get();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await Get(id);
        }

        public void UpdateProduct(Product product)
        {
            Update(product);
        }
    }
}
