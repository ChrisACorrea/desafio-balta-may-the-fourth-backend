using MayTheFourth.API.Helpers;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MayTheFourth.API.Routes;

public static class VehicleRoutes
{
    public static void MapVehiclesRoutes(this IEndpointRouteBuilder app)
    {
        app.MapGet(Urls.GetVehiclesList, async (
            [FromQuery(Name = "page")] int? page,
            [FromQuery(Name = "limit")] int? limit,
            IVehicleService service, CancellationToken cancellation) =>
            await ApiHelper.GetAllPagedAsync<VehicleVM, ListVehicles, Vehicle>(
                service,
                page ?? 0,
                limit ?? 0,
                cancellation))
        .WithName(nameof(Urls.GetVehiclesList))
        .WithOpenApi()
        .WithTags("Vehicles");

        app.MapGet(Urls.GetVehicleById, async (
            IVehicleService service,
            Guid id,
            CancellationToken cancellation) =>
            await ApiHelper.GetByKeyAsync(
                service, r => r.Id == id,
                cancellation))
        .WithName(nameof(Urls.GetVehicleById))
        .WithOpenApi()
        .WithTags("Vehicles");


        app.MapPost(Urls.PostVehicle, async (
            IVehicleService service,
            VehicleVM vehicle,
            CancellationToken cancellation) =>
        {
            var result = await service.CreateAsync(vehicle, cancellation);

            return ApiHelper.ResultOperation(
                result, service
            );
        })
        .WithName(nameof(Urls.PostVehicle))
        .WithOpenApi()
        .WithTags("Vehicles");

        app.MapPut(Urls.PutVehicleById, async (
            IVehicleService service,
            Guid id,
            VehicleVM vehicle,
            CancellationToken cancellation) =>
        {
            vehicle.Id = id;

            var result = await service.ChangeAsync(vehicle, cancellation);

            return ApiHelper.ResultOperation(
                result, service
            );
        })
        .WithName(nameof(Urls.PutVehicleById))
        .WithOpenApi()
        .WithTags("Vehicles");

        app.MapDelete(Urls.DeleteVehicleById, async (
            IVehicleService service,
            Guid id,
            CancellationToken cancellation) =>
            await ApiHelper.RemoveByIdAsync(
                service, id,
                cancellation))
        .WithName(nameof(Urls.DeleteVehicleById))
        .WithOpenApi()
        .WithTags("Vehicles");
    }
}
