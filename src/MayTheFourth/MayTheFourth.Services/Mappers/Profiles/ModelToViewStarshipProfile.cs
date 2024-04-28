using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ModelToViewStarshipProfile : Profile
{
    public ModelToViewStarshipProfile()
    {
        CreateMap<Starship, StarshipVM>();
        CreateMap<PageListResult<Starship>, PageListResult<StarshipVM>>();
    }
}
