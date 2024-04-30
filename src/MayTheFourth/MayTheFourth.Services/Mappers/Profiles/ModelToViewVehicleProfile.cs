using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ModelToViewVehicleProfile : Profile
{
    public ModelToViewVehicleProfile()
    {
        CreateMap<Vehicle, VehicleVM>();
        CreateMap<Vehicle, ListVehicles>();
        CreateMap<Vehicle, ListMovieVehicles>();

        CreateMap<PageListResult<Vehicle>, PageListResult<VehicleVM>>();
        CreateMap<PageListResult<Vehicle>, PageListResult<ListVehicles>>();
        CreateMap<PageListResult<Vehicle>, PageListResult<ListMovieVehicles>>();
    }
}
