using Concessionaria.API.Application.Services;
using Concessionaria.API.Domain.Interfaces;
using Concessionaria.API.Infrastructure.Data.AppData;
using Concessionaria.API.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Concessionaria.API.Infrastructure.IoC
{

    public static class Bootstrap
    { 
    public static void Start(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationContext>(x => {
            x.UseOracle(configuration["ConnectionStrings:Oracle"]);
        });


        services.AddTransient<ICategoriaRepository, CategoriaRepository>();
    


        services.AddTransient<ICategoriaApplicationService, CategoriaApplicationServices>();
  
     }
    }

}
