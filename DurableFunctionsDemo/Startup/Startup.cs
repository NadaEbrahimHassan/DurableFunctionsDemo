using AutoMapper;
using Data;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly:FunctionsStartup(typeof(DurableFunctionsDemo.Startup.Startup))]
namespace DurableFunctionsDemo.Startup
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddDbContext<OnlineShoppingContext>(options =>
            {
                options.UseSqlServer("Data Source =.\\Nada2016; initial catalog = onlineShopping;User ID = SDAssignmentAdmin; Password = 123456");
            });
            builder.Services.AddSingleton<OnlineShoppingContext>();
           
        }
    }
}
