using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ViewToModelPlanetProfile : Profile
{
    public ViewToModelPlanetProfile()
    {
        CreateMap<PlanetVM, Planet>();
        CreateMap<PlanetVM, ListPlanets>();
        CreateMap<PlanetVM, ListCharacterPlanet>();
        CreateMap<PlanetVM, ListMoviePlanets>();

        CreateMap<PageListResult<PlanetVM>, PageListResult<Planet>>();
        CreateMap<PageListResult<PlanetVM>, PageListResult<ListPlanets>>();
        CreateMap<PageListResult<PlanetVM>, PageListResult<ListCharacterPlanet>>();
        CreateMap<PageListResult<PlanetVM>, PageListResult<ListMoviePlanets>>();
    }
}
