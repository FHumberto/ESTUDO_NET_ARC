using CAEFMR.Api.Extensions;
using CAEFMR.Application;
using CAEFMR.Persistence;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

#region CAMADAS

builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceLayer(builder.Configuration);

#endregion

builder.Services.AddControllers();

builder.Services.AddSwaggerWithVersioning();

WebApplication? app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerWithVersioning();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
