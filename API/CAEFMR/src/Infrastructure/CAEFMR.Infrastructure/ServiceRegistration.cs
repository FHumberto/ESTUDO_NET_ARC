using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CAEFMR.Infrastructure;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
