using MayTheFourth.API.Helpers;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFourth.API.Routes;

public static class StarshipRoutes
{
    public static void MapStarshipsRoutes(this IEndpointRouteBuilder app)
    {
        app.MapGet(Urls.GetStarshipsList, async (
            [FromQuery(Name = "page")] int? page,
            [FromQuery(Name = "limit")] int? limit,
            IStarshipService service, CancellationToken cancellation) =>
        {
            return await ApiHelper.GetAllPagedAsync<StarshipVM, ListStarships, Starship>(
                service,
                page ?? 0,
                limit ?? 0,
                cancellation);
        })
        .WithName(nameof(Urls.GetStarshipsList))
        .WithOpenApi()
        .WithTags("Starships");

        app.MapGet(Urls.GetStarshipById, async (
            IStarshipService service,
            Guid id,
            CancellationToken cancellation) =>
        {
            return await ApiHelper.GetByKeyAsync(
                service, r => r.Id == id,
                cancellation);
        })
        .WithName(nameof(Urls.GetStarshipById))
        .WithOpenApi()
        .WithTags("Starships");


        app.MapPost(Urls.PostStarship, async (
            IStarshipService service,
            StarshipVM starship,
            CancellationToken cancellation) =>
        {
            var result = await service.CreateAsync(starship, cancellation);

            return ApiHelper.ResultOperation<StarshipVM, Starship>(
                result, service
            );
        })
        .WithName(nameof(Urls.PostStarship))
        .WithOpenApi()
        .WithTags("Starships");

        app.MapPut(Urls.PutStarshipById, async (
            IStarshipService service,
            Guid id,
            StarshipVM starship,
            CancellationToken cancellation) =>
        {
            starship.Id = id;

            var result = await service.ChangeAsync(starship, cancellation);

            return ApiHelper.ResultOperation<StarshipVM, Starship>(
                result, service
            );
        })
        .WithName(nameof(Urls.PutStarshipById))
        .WithOpenApi()
        .WithTags("Starships");

        app.MapDelete(Urls.DeleteStarshipById, async (
            IStarshipService service,
            Guid id,
            CancellationToken cancellation) =>
        {
            return await ApiHelper.RemoveByIdAsync(
                service, id,
                cancellation);
        })
        .WithName(nameof(Urls.DeleteStarshipById))
        .WithOpenApi()
        .WithTags("Starships");
    }
}
