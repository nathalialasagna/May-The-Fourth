using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;
using MayTheFourth.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCarter();

ConfigureServices(builder);

var app = builder.Build();
ConfigureApiServices(app);

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapCarter();

app.Run();

void ConfigureServices(WebApplicationBuilder builder)
{

    builder.Services.AddDbContext<MayTheFourthDataContext>(options => options.UseLazyLoadingProxies()
                                                                             .UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

    // Repositories services
    builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();
    builder.Services.AddScoped<INavesEstelaresRepository, NavesEstelaresRepository>();
    builder.Services.AddScoped<IPersonagemRepository, PersonagemRepository>();
    builder.Services.AddScoped<IPlanetaRepository, PlanetaRepository>();
    builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();

}

void ConfigureApiServices(WebApplication webApplication)
{

}