using MayTheFourth.API.Helpers;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
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
            IConfiguration configuration,
            ICharacterService service, CancellationToken cancellation) => 
                await ApiHelper.GetAllPagedAsync<CharacterVM, ListCharacters, Character>(
                service,
                page ?? 0,
                limit ?? 0,
                cancellation))
        .WithName(nameof(Urls.GetCharactersList))
        .WithOpenApi()
        .WithTags("Characters");

        app.MapGet(Urls.GetCharacterById, async (
            ICharacterService service,
            Guid id,
            CancellationToken cancellation) =>
            await ApiHelper.GetByKeyAsync(
                service, r => r.Id == id,
                cancellation))
        .WithName(nameof(Urls.GetCharacterById))
        .WithOpenApi()
        .WithTags("Characters");


        app.MapPost(Urls.PostCharacter, async (
            ICharacterService service,
            CharacterVM character,
            CancellationToken cancellation) =>
        {
            var result = await service.CreateAsync(character, cancellation);

            return ApiHelper.ResultOperation(
                result, service
            );
        })
        .WithName(nameof(Urls.PostCharacter))
        .WithOpenApi()
        .WithTags("Characters");

        app.MapPut(Urls.PutCharacterById, async (
            ICharacterService service,
            Guid id,
            CharacterVM character,
            CancellationToken cancellation) =>
        {
            character.Id = id;

            var result = await service.ChangeAsync(character, cancellation);

            return ApiHelper.ResultOperation(
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
            await ApiHelper.RemoveByIdAsync(
                service, id,
                cancellation))
        .WithName(nameof(Urls.DeleteCharacterById))
        .WithOpenApi()
        .WithTags("Characters");
    }
}
