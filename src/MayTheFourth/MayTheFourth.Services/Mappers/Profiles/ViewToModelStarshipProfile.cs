using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ViewToModelStarshipProfile : Profile
{
    public ViewToModelStarshipProfile()
    {
        CreateMap<StarshipVM, Starship>();
        CreateMap<StarshipVM, ListStarships>();
        CreateMap<StarshipVM, ListMovieStarships>();

        CreateMap<PageListResult<StarshipVM>, PageListResult<Starship>>();
        CreateMap<PageListResult<StarshipVM>, PageListResult<ListStarships>>();
        CreateMap<PageListResult<StarshipVM>, PageListResult<ListMovieStarships>>();
    }
}
