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
        string connectionString = configuration.GetConnectionString("AppDbContext") ?? throw new InvalidOperationException("Connection string 'AppDbContext' is not found.");

        services.AddHealthChecks()
            .AddSqlServer(connectionString, name: "Sql Server Check");

        services.AddHealthChecksUI()
            .AddInMemoryStorage();

        return services;
    }
}
