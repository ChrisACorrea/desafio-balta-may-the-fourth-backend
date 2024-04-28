using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ViewToModelCharacterProfile : Profile
{
    public ViewToModelCharacterProfile()
    {
        CreateMap<CharacterVM, Character>();
        CreateMap<PageListResult<CharacterVM>, PageListResult<Character>>();
    }
}
