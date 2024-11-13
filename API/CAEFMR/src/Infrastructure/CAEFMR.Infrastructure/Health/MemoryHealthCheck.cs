using CAEFMR.Infrastructure.Models;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;

namespace CAEFMR.Infrastructure.Health;

public class MemoryHealthCheck(IOptionsMonitor<MemoryCheckOptions> options) : IHealthCheck
{
    private readonly IOptionsMonitor<MemoryCheckOptions> _options = options;

    public static string Name => "memory_check";

    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        MemoryCheckOptions options = _options.Get(context.Registration.Name);

        long allocated = GC.GetTotalMemory(forceFullCollection: false);

        Dictionary<string, object> data = new()
        {
            { "AllocatedBytes", allocated },
            { "Gen0Collections", GC.CollectionCount(0) },
            { "Gen1Collections", GC.CollectionCount(1) },
            { "Gen2Collections", GC.CollectionCount(2) },
        };

        HealthStatus status = allocated < options.Threshold ? HealthStatus.Healthy : HealthStatus.Unhealthy;

        return Task.FromResult
            (new HealthCheckResult(
                status,
                description: $"Relata status degradado se os bytes alocados forem >= {options.Threshold} bytes.",
                exception: null,
                data: data
            ));
    }
}
