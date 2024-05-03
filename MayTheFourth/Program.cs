using Carter;
using MayTheFourth.Domain.Interfaces.Repositories;
using MayTheFourth.Infra.Context;
using MayTheFourth.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.Configure<Microsoft.AspNetCore.Http.Json.JsonOptions>(options => options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddSwaggerGen();
builder.Services.AddCarter();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<MayTheFourthDataContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Repositories services
builder.Services.AddScoped<IFilmeRepository, FilmeRepository>();
builder.Services.AddScoped<INaveEstelarRepository, NaveEstelarRepository>();
builder.Services.AddScoped<IPersonagemRepository, PersonagemRepository>();
builder.Services.AddScoped<IPlanetaRepository, PlanetaRepository>();
builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();


var app = builder.Build();
ConfigureApiServices(app);

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapCarter();

app.Run();





void ConfigureApiServices(WebApplication webApplication)
{

}