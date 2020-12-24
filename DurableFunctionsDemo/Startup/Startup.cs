using Data;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


[assembly:FunctionsStartup(typeof(DurableFunctionsDemo.Startup.Startup))]
namespace DurableFunctionsDemo.Startup
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddDbContext<OnlineShoppingContext>(options =>
            {
                options.UseSqlServer("Data Source =.\\Nada2016; initial catalog = onlineShopping;User ID = SDAssignmentAdmin; Password = 123456");
            });
            builder.Services.AddSingleton<OnlineShoppingContext>();
        }
    }
}
