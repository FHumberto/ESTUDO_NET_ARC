using CAEFMR.Api.Extensions;
using CAEFMR.Api.Middlewares;
using CAEFMR.Application;
using CAEFMR.Identity;
using CAEFMR.Infrastructure;
using CAEFMR.Persistence;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

#region [HEALTH_CHECK SERVICES]

builder.Services.AddCustomHealthChecks
    (builder.Configuration);

#endregion

#region [ACOPLAMENTO DAS CAMADAS]

builder.Services.AddApplicationLayer();
builder.Services.AddInfrastructureLayer(builder.Configuration);
builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddIdentityLayer(builder.Configuration);

#endregion

builder.Services.AddControllers();

builder.Services.AddSwaggerWithVersioning();

builder.Services.AddCorsPolicies();

builder.Services.AddRateLimiterPolicies();

WebApplication app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

app.UseCorsPolicies();

app.UseRateLimiter();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerWithVersioning();
}

# region [HEALTH_CHECK MAP]

app.MapHealthChecks("/health",
    new HealthCheckOptions
    {
        Predicate = _ => true,
        ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
    });

app.UseHealthChecksUI(options =>
{
    options.UIPath = "/dashboard";
});

#endregion

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
