using AutoMapper;
using Core.Models;
using Repositories.UnitOfWork;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public ProductService(UnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<List<ProductModel>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetProductQuntity(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
