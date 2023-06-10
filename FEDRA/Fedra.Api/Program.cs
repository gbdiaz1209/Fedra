using Fedra.Api.Common;
using Fedra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Fedra",
        Version = "v1.0"
    });
});

// Resolver inyeccion de dependencias
var dependencyInjections = new DependencyInjections();
builder = dependencyInjections.ConfigAppDependencies(builder);
builder.Services.AddDbContext<FedraDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("fedraConnection"), b => b.MigrationsAssembly("Fedra.Data")));

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
