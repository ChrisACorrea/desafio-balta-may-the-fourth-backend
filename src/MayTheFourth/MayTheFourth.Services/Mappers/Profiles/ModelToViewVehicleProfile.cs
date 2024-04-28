using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ModelToViewVehicleProfile : Profile
{
    public ModelToViewVehicleProfile()
    {
        CreateMap<Vehicle, VehicleVM>();
        CreateMap<PageListResult<Vehicle>, PageListResult<VehicleVM>>();
    }
}
