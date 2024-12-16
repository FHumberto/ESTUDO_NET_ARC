using Microsoft.Extensions.DependencyInjection;

namespace CA_CQRS_MR.Infrastructure;

public static class LayerRegistration
{
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services)
    {
        return services;
    }
}
