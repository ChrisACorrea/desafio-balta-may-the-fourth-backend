using MayTheFourth.API.Helpers;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFourth.API.Routes;

public static class PlanetRoutes
{
    public static void MapPlanetsRoutes(this IEndpointRouteBuilder app)
    {
        app.MapGet(Urls.GetPlanetsList, async (
            [FromQuery(Name = "page")] int? page,
            [FromQuery(Name = "limit")] int? limit,
            IPlanetService service, CancellationToken cancellation) =>
        {
            return await ApiHelper.GetAllPagedAsync<PlanetVM, ListPlanets, Planet>(
                service,
                page ?? 0,
                limit ?? 0,
                cancellation);
        })
        .WithName(nameof(Urls.GetPlanetsList))
        .WithOpenApi()
        .WithTags("Planets");

        app.MapGet(Urls.GetPlanetById, async (
            IPlanetService service,
            Guid id,
            CancellationToken cancellation) =>
        {
            return await ApiHelper.GetByKeyAsync(
                service, r => r.Id == id,
                cancellation);
        })
        .WithName(nameof(Urls.GetPlanetById))
        .WithOpenApi()
        .WithTags("Planets");


        app.MapPost(Urls.PostPlanet, async (
            IPlanetService service,
            PlanetVM planet,
            CancellationToken cancellation) =>
        {
            var result = await service.CreateAsync(planet, cancellation);

            return ApiHelper.ResultOperation<PlanetVM, Planet>(
                result, service
            );
        })
        .WithName(nameof(Urls.PostPlanet))
        .WithOpenApi()
        .WithTags("Planets");

        app.MapPut(Urls.PutPlanetById, async (
            IPlanetService service,
            Guid id,
            PlanetVM planet,
            CancellationToken cancellation) =>
        {
            planet.Id = id;

            var result = await service.ChangeAsync(planet, cancellation);

            return ApiHelper.ResultOperation<PlanetVM, Planet>(
                result, service
            );
        })
        .WithName(nameof(Urls.PutPlanetById))
        .WithOpenApi()
        .WithTags("Planets");

        app.MapDelete(Urls.DeletePlanetById, async (
            IPlanetService service,
            Guid id,
            CancellationToken cancellation) =>
        {
            return await ApiHelper.RemoveByIdAsync(
                service, id,
                cancellation);
        })
        .WithName(nameof(Urls.DeletePlanetById))
        .WithOpenApi()
        .WithTags("Planets");
    }
}
