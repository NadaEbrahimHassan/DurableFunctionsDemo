using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Interfaces
{
    public interface IProductRepository
    {
         void UpdateProduct(Product product);
    }
}
