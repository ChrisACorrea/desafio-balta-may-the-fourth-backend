using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ViewToModelVehicleProfile : Profile
{
    public ViewToModelVehicleProfile()
    {
        CreateMap<VehicleVM, Vehicle>();
        CreateMap<PageListResult<VehicleVM>, PageListResult<Vehicle>>();
    }
}
