using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ViewToModelPlanetProfile : Profile
{
    public ViewToModelPlanetProfile()
    {
        CreateMap<PlanetVM, Planet>();
        CreateMap<PageListResult<PlanetVM>, PageListResult<Planet>>();
    }
}
