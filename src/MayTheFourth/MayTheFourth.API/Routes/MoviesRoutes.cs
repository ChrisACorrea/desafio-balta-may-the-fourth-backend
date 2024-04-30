using MayTheFourth.API.Helpers;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFourth.API.Routes
{
    public static class MoviesRoutes
    {
        public static void MapMoviesRoutes(this IEndpointRouteBuilder app)
        {
            app.MapGet(Urls.GetMoviesList, async (
                [FromQuery(Name = "page")] int? page,
                [FromQuery(Name = "limit")] int? limit,
                IMovieService service, CancellationToken cancellation) =>
            {
                return await ApiHelper.GetAllPagedAsync<MovieVM, ListMovies, Movie>(
                    service,
                    page ?? 0,
                    limit ?? 0,
                    cancellation);
            })
            .WithName(nameof(Urls.GetMoviesList))
            .WithOpenApi()
            .WithTags("Movies");

            app.MapGet(Urls.GetMovieById, async (
                IMovieService service,
                Guid id,
                CancellationToken cancellation) =>
            {
                return await ApiHelper.GetByKeyAsync(
                    service, r => r.Id == id,
                    cancellation);
            })
            .WithName(nameof(Urls.GetMovieById))
            .WithOpenApi()
            .WithTags("Movies");


            app.MapPost(Urls.PostMovie, async (
                IMovieService service,
                MovieVM movie,
                CancellationToken cancellation) =>
            {
                var result = await service.CreateAsync(movie, cancellation);

                return ApiHelper.ResultOperation<MovieVM, Movie>(
                    result, service
                );
            })
            .WithName(nameof(Urls.PostMovie))
            .WithOpenApi()
            .WithTags("Movies");

            app.MapPut(Urls.PutMovieById, async (
                IMovieService service,
                Guid id,
                MovieVM movie,
                CancellationToken cancellation) =>
            {
                movie.Id = id;

                var result = await service.ChangeAsync(movie, cancellation);

                return ApiHelper.ResultOperation<MovieVM, Movie>(
                    result, service
                );
            })
            .WithName(nameof(Urls.PutMovieById))
            .WithOpenApi()
            .WithTags("Movies");

            app.MapDelete(Urls.DeleteMovieById, async (
                IMovieService service,
                Guid id,
                CancellationToken cancellation) =>
            {
                return await ApiHelper.RemoveByIdAsync(
                    service, id,
                    cancellation);
            })
            .WithName(nameof(Urls.DeleteMovieById))
            .WithOpenApi()
            .WithTags("Movies");
        }
    }
}
