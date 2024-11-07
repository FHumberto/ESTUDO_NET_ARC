using CAEFMR.Api.Extensions;
using CAEFMR.Api.Middlewares;
using CAEFMR.Application;
using CAEFMR.Identity;
using CAEFMR.Persistence;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

#region CAMADAS

builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddIdentityLayer(builder.Configuration);

#endregion

builder.Services.AddControllers();

builder.Services.AddSwaggerWithVersioning();

builder.Services.AddCorsPolicies();

WebApplication app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();

app.UseCorsPolicies();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerWithVersioning();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
