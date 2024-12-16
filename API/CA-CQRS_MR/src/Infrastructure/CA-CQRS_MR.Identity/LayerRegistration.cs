using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CA_CQRS_MR.Identity;

public static class LayerRegistration
{
    public static IServiceCollection AddIdentityLayer(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
