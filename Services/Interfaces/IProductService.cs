using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetAllProducts();
        Task<int> GetProductQuntity(int productId);
    }
}
