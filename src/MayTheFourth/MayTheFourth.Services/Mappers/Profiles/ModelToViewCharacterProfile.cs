using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ModelToViewCharacterProfile : Profile
{
    public ModelToViewCharacterProfile()
    {
        CreateMap<Character, CharacterVM>();
        CreateMap<Character, ListPlanetCharacter>();
        CreateMap<Character, ListCharacters>();
        CreateMap<Character, ListMovieCharacters>();

        CreateMap<PageListResult<Character>, PageListResult<CharacterVM>>();
        CreateMap<PageListResult<Character>, PageListResult<ListPlanetCharacter>>();
        CreateMap<PageListResult<Character>, PageListResult<ListCharacters>>();
        CreateMap<PageListResult<Character>, PageListResult<ListMovieCharacters>>();
    }
}
