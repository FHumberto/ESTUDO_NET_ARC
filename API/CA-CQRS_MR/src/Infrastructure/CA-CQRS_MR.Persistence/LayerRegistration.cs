using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CA_CQRS_MR.Persistence;

public static class LayerRegistration
{
    public static IServiceCollection AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
