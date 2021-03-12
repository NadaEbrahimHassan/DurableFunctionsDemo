using AutoMapper;
using Core.Models;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Utilities
{
    class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderModel>().ReverseMap();
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<Courier, CourierModel>().ReverseMap();
            CreateMap<OrderShippingDetails, OrderShippingDetailsModel>().ReverseMap();
        }
    }
}
