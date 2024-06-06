using Microsoft.EntityFrameworkCore;
using OceanObservationAPI.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var stringConexao = builder.Configuration.GetConnectionString("OracleConnection");
builder.Services.AddDbContext<OceanDataContext>(options =>
{
    options.UseOracle(stringConexao);
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "OceanObservationAPI V1");
        c.RoutePrefix = string.Empty; // Serve Swagger UI at app's root
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
