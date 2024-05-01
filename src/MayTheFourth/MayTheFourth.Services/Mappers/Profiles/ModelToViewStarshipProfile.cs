using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ModelToViewStarshipProfile : Profile
{
    public ModelToViewStarshipProfile()
    {
        CreateMap<Starship, StarshipVM>();
        CreateMap<Starship, ListStarships>();
        CreateMap<Starship, ListMovieStarships>();

        CreateMap<PageListResult<Starship>, PageListResult<StarshipVM>>();
        CreateMap<PageListResult<Starship>, PageListResult<ListStarships>>();
        CreateMap<PageListResult<Starship>, PageListResult<ListMovieStarships>>();
    }
}
