using CA_CQRS_MR.Application;
using CA_CQRS_MR.Identity;
using CA_CQRS_MR.Infrastructure;
using CA_CQRS_MR.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructureLayer();
builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddIdentityLayer(builder.Configuration);
builder.Services.AddApplicationLayer();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
