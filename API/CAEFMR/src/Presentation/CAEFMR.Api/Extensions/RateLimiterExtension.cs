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
            #region ===[ POLICIES ]====================================================================================

            options.GlobalLimiter = PartitionedRateLimiter.Create<HttpContext, string>(httpContext
                => RateLimitPartition.GetFixedWindowLimiter("Fixed", _
                    => new FixedWindowRateLimiterOptions
                    {
                        PermitLimit = 100, // quantidade de requisições
                        Window = TimeSpan.FromMinutes(1), // a cada um minuto
                        QueueProcessingOrder = QueueProcessingOrder.OldestFirst, // processamento (ordem de chegada)
                        QueueLimit = 2 // limite de 2 requisições na fila de espera
                    }));

            #endregion

            #region ===[ RESPONSE ]====================================================================================

            //? personaliza a resposta de rejeição
            options.OnRejected = async (context, cancellationToken) =>
            {
                context.HttpContext.Response.StatusCode = 429; //* Too Many Requests
                await context.HttpContext.Response.WriteAsJsonAsync(
                    new { message = "Você excedeu o limite de requisições. Tente novamente mais tarde." },
                    cancellationToken);
            };

            #endregion
        });

        return services;
    }
}
