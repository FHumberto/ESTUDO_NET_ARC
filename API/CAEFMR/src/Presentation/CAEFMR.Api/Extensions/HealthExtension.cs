using CAEFMR.Infrastructure.Health;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace CAEFMR.Api.Extensions;

public static class HealthCheckExtension
{
    /// <summary>
    /// Adiciona HealthChecks personalizados ao serviço e configura o HealthChecks UI com armazenamento em memória.
    /// </summary>
    /// <param name="services">A coleção de serviços da aplicação.</param>
    /// <param name="configuration">A configuração da aplicação que fornece a string de conexão do banco de dados.</param>
    /// <returns>Retorna a coleção de serviços configurada.</returns>
    /// <exception cref="InvalidOperationException">Lançada se a string de conexão 'AppDbContext' não for encontrada.</exception>
    public static IServiceCollection AddCustomHealthChecks(this IServiceCollection services, IConfiguration configuration)
    {
        #region ===[ SETTINGS ]========================================================================================

        string? connectionString = configuration["ConnectionStrings:AppDbContext"];

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Connection string 'AppDbContext' not found.");
        }

        #endregion

        #region ===[ CHECKS ]==========================================================================================

        services.AddHealthChecks()
            .AddSqlServer(connectionString,
                healthQuery: "select 1",
                name: "SQL Server",
                failureStatus: HealthStatus.Unhealthy,
                tags: new[] { "Serviço", "Database" })

            .AddCheck<RemoteHealthCheck>(
                name: "Internet Check",
                failureStatus: HealthStatus.Unhealthy,
                tags: new[] { "Serviço", "Infraestrutura" })

            .AddCheck<MemoryHealthCheck>(
                name: $"Memory Check",
                failureStatus: HealthStatus.Unhealthy,
                tags: new[] { "Serviço", "Infraestrutura" });

        #endregion

        #region ===[ CONFIGURATION ]===================================================================================

        services.AddHealthChecksUI(opt =>
        {
            opt.SetEvaluationTimeInSeconds(10); // intervalo de checagem em segundos
            opt.MaximumHistoryEntriesPerEndpoint(60); // histórico máximo de checagem  
            opt.SetApiMaxActiveRequests(1); //concorrência de requests  
            opt.AddHealthCheckEndpoint("Aplicação", "/api/health");
        })
        .AddInMemoryStorage();

        #endregion

        return services;
    }
}
