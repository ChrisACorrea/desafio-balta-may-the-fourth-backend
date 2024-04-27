using MayTheFourth.API.Helpers;
using MayTheFourth.Entities;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFourth.API.Routes;

public static class CharacterRoutes
{
    public static void MapCharactersRoutes(this IEndpointRouteBuilder app)
    {
        app.MapGet(Urls.GetCharactersList, async (
            [FromQuery(Name = "page")] int? page,
            [FromQuery(Name = "limit")] int? limit,
            ICharacterService service, CancellationToken cancellation) =>
        {
            return await ApiHelper.GetAllPagedAsync(
                service,
                page ?? 0,
                limit ?? 0,
                cancellation);
        })
        .WithName(nameof(Urls.GetCharactersList))
        .WithOpenApi()
        .WithTags("Characters");

        app.MapGet(Urls.GetCharacterById, async (
            ICharacterService service,
            Guid id,
            CancellationToken cancellation) =>
        {
            return await ApiHelper.GetByKeyAsync(
                service, r => r.Id == id,
                cancellation);
        })
        .WithName(nameof(Urls.GetCharacterById))
        .WithOpenApi()
        .WithTags("Characters");


        app.MapPost(Urls.PostCharacter, async (
            ICharacterService service,
            CharacterVM movie,
            CancellationToken cancellation) =>
        {
            var result = await service.CreateAsync(movie, cancellation);

            return ApiHelper.ResultOperation<CharacterVM, Character>(
                result, service
            );
        })
        .WithName(nameof(Urls.PostCharacter))
        .WithOpenApi()
        .WithTags("Characters");

        app.MapPut(Urls.PutCharacterById, async (
            ICharacterService service,
            Guid id,
            CharacterVM movie,
            CancellationToken cancellation) =>
        {
            movie.Id = id;

            var result = await service.ChangeAsync(movie, cancellation);

            return ApiHelper.ResultOperation<CharacterVM, Character>(
                result, service
            );
        })
        .WithName(nameof(Urls.PutCharacterById))
        .WithOpenApi()
        .WithTags("Characters");

        app.MapDelete(Urls.DeleteCharacterById, async (
            ICharacterService service,
            Guid id,
            CancellationToken cancellation) =>
        {
            return await ApiHelper.RemoveByIdAsync(
                service, id,
                cancellation);
        })
        .WithName(nameof(Urls.DeleteCharacterById))
        .WithOpenApi()
        .WithTags("Characters");
    }
}
