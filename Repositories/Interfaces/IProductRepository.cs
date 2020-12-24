using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IProductRepository
    {
        public void UpdateProduct(Product product);
    }
}
