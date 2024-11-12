using System.Threading.RateLimiting;

namespace CAEFMR.Api.Extensions;

public static class RateLimiterExtension
{
    /// <summary>
    /// Adiciona a politica de Rate Limiter configurada à coleção de serviços da aplicação.
    /// </summary>
    /// <param name="services">A coleção de serviços da aplicação.</param>
    /// <returns>A coleção de serviços da aplicação com a política de Reate Limiter adicionada.</returns>
    public static IServiceCollection AddRateLimiterPolicies(this IServiceCollection services)
    {
        services.AddRateLimiter(options =>
        {
            //? configuração da poilitica global
            options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>
            (httpContext => RateLimitPartition.GetFixedWindowLimiter("Fixed", _
                => new FixedWindowRateLimiterOptions
                {
                    PermitLimit = 100,
                    Window = TimeSpan.FromMinutes(1),
                    QueueProcessingOrder = QueueProcessingOrder.OldestFirst, // Ordem de processamento (ordem de chegada)
                    QueueLimit = 2 // Limite de 2 requisições na fila de espera
                }));

            //? personaliza a resposta de rejeição
            options.OnRejected = async (context, cancellationToken) =>
            {
                context.HttpContext.Response.StatusCode = 429; //* Too Many Requests
                await context.HttpContext.Response.WriteAsJsonAsync(
                    new { message = "Você excedeu o limite de requisições. Tente novamente mais tarde." },
                    cancellationToken);
            };
        });

        return services;
    }
}
