using CAEFMR.Application;
using CAEFMR.Persistence;

var builder = WebApplication.CreateBuilder(args);

#region CAMADAS

builder.Services.AddApplicationLayer();
builder.Services.AddPersistenceLayer(builder.Configuration);

#endregion

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
