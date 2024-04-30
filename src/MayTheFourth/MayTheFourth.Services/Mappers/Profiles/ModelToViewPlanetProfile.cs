using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ModelToViewPlanetProfile : Profile
{
    public ModelToViewPlanetProfile()
    {
        CreateMap<Planet, PlanetVM>();
        CreateMap<Planet, ListPlanets>();
        CreateMap<Planet, ListCharacterPlanet>();
        CreateMap<Planet, ListMoviePlanets>();

        CreateMap<PageListResult<Planet>, PageListResult<PlanetVM>>();
        CreateMap<PageListResult<Planet>, PageListResult<ListPlanets>>();
        CreateMap<PageListResult<Planet>, PageListResult<ListCharacterPlanet>>();
        CreateMap<PageListResult<Planet>, PageListResult<ListMoviePlanets>>();
    }
}