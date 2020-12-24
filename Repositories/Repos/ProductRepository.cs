﻿using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Repos
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private DbContext _context;
        public ProductRepository(DbContext context) : base(context)
        {
            _context = context;
        }
        public void UpdateProduct(Product product)
        {
            Update(product);
        }
    }
}