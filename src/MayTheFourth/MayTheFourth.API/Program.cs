using AutoMapper;
using MayTheFourth.API.Helpers;
using MayTheFourth.API.Routes;
using MayTheFourth.Entities;
using MayTheFourth.IoC;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.Mappers;
using MayTheFourth.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "MayTheFourth", Version = "v1" });
});

builder.Services.AddServices(builder.Configuration);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.WriteIndented = true;
    options.SerializerOptions.IncludeFields = true;
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("./v1/swagger.json", "MayTheFourth");
});

MapperModel.SetMapper(app.Services.GetRequiredService<IMapper>());

app.UseHttpsRedirection();

app.MapRoutes();

app.Run();
