using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ModelToViewCharacterProfile : Profile
{
    public ModelToViewCharacterProfile()
    {
        CreateMap<Character, CharacterVM>();
        CreateMap<PageListResult<Character>, PageListResult<CharacterVM>>();
    }
}
