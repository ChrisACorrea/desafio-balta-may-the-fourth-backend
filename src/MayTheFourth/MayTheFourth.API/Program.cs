using AutoMapper;
using MayTheFourth.API.Routes;
using MayTheFourth.IoC;
using MayTheFourth.Services.Mappers;
using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "MayTheFourth", 
        Description = "Developed by Christopher Corrêa | Gabriel Ferreira | Jonathan Vale | Gabriel | André",
        Contact = new OpenApiContact
        {
            Name = "MayTheFourth",
            Url = new Uri("https://github.com/KennyMack/desafio-balta-may-the-fourth-backend")
        },
        
        Version = "v1"
    });
});

builder.Services.AddServices(builder.Configuration);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.WriteIndented = true;
    options.SerializerOptions.IncludeFields = true;
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("MayTheFourth", cors =>
    {
        cors.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddMemoryCache();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("./v1/swagger.json", "MayTheFourth");
});

MapperModel.SetMapper(app.Services.GetRequiredService<IMapper>());

app.UseHttpsRedirection();

app.UseCors("MayTheFourth");

app.MapRoutes();

app.Run();
