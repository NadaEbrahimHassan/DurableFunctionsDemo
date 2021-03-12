using AutoMapper;
using Core.Models;
using Data.Entities;
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
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public  async Task<List<ProductModel>> GetAllProducts()
        {
           var products= await _unitOfWork.ProductRepository.GetAllProducts();
            return _mapper.Map<List<Product>, List<ProductModel>>(products);
        }

        public async Task<int> GetProductQuntity(int productId)
        {
            return  (await _unitOfWork.ProductRepository.GetProductById(productId))?.Quntity ?? 0;
        }
    }
}
