using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace CAEFMR.Infrastructure.Health;

public class RemoteHealthCheck(IHttpClientFactory httpClientFactory) : IHealthCheck
{
    public IHttpClientFactory HttpClientFactory => httpClientFactory;

    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
    {
        using HttpClient httpClient = HttpClientFactory.CreateClient();

        HttpResponseMessage response = await httpClient.GetAsync("https://api.ipify.org", cancellationToken);

        return response.IsSuccessStatusCode
            ? HealthCheckResult.Healthy("Com acesso aos endpoints listados")
            : HealthCheckResult.Unhealthy("Sem acesso aos endpoints listados");

    }
}
