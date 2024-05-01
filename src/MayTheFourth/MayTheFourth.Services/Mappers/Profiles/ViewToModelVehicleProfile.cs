using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ViewToModelVehicleProfile : Profile
{
    public ViewToModelVehicleProfile()
    {
        CreateMap<VehicleVM, Vehicle>();
        CreateMap<VehicleVM, ListVehicles>();
        CreateMap<VehicleVM, ListMovieVehicles>();

        CreateMap<PageListResult<VehicleVM>, PageListResult<Vehicle>>();
        CreateMap<PageListResult<VehicleVM>, PageListResult<ListVehicles>>();
        CreateMap<PageListResult<VehicleVM>, PageListResult<ListMovieVehicles>>();
    }
}
