using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ModelToViewPlanetProfile : Profile
{
    public ModelToViewPlanetProfile()
    {
        CreateMap<Planet, PlanetVM>();
        CreateMap<PageListResult<Planet>, PageListResult<PlanetVM>>();
    }
}
