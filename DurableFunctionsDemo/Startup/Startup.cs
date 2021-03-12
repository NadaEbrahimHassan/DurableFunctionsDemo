using AutoMapper;
using Data;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Interfaces;
using Repositories.Repos;
using Repositories.UnitOfWork;
using Services;
using Services.Interfaces;
using System;

[assembly:FunctionsStartup(typeof(DurableFunctionsDemo.Startup.Startup))]
namespace DurableFunctionsDemo.Startup
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //builder.Services.AddDbContext<OnlineShoppingContext>(options =>
            //{
            //    options.UseSqlServer("Data Source =.\\Nada2016;initial catalog = onlineShopping;User ID = SDAssignmentAdmin;Password = 123456");
            //});
            builder.Services.AddSingleton<DbContext, OnlineShoppingContext>();

            builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            builder.Services.AddScoped(typeof(IProductRepository), typeof(ProductRepository));
            builder.Services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
            builder.Services.AddScoped(typeof(ICourierRepository), typeof(CourierRepository));
            builder.Services.AddScoped(typeof(IOrderShippingDetails), typeof(OrderShippingDetailsRepository));


            builder.Services.AddScoped(typeof(IOrderService), typeof(OrderService));
            builder.Services.AddScoped(typeof(IOrderShippingDetailsService), typeof(OrderShippingDetailsService));
            builder.Services.AddScoped(typeof(ICourierService), typeof(CourierService));
            builder.Services.AddScoped(typeof(IProductService), typeof(ProductService));
        }
    }
}
