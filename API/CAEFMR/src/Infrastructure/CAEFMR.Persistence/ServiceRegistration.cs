using CAEFMR.Application.Interfaces.Repositories;
using CAEFMR.Persistence.Contexts;
using CAEFMR.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CAEFMR.Persistence;

public static class ServiceRegistration
{
    public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("AppDbContext"));
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IExampleRepository, ExampleRepository>();

        return services;
    }
}
