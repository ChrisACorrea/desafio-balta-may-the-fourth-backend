using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ViewToModelStarshipProfile : Profile
{
    public ViewToModelStarshipProfile()
    {
        CreateMap<StarshipVM, Starship>();
        CreateMap<PageListResult<StarshipVM>, PageListResult<Starship>>();
    }
}
