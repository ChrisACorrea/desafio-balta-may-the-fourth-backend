using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles;

public class ViewToModelCharacterProfile : Profile
{
    public ViewToModelCharacterProfile()
    {
        CreateMap<CharacterVM, Character>();
        CreateMap<CharacterVM, ListPlanetCharacter>();
        CreateMap<CharacterVM, ListCharacters>();
        CreateMap<CharacterVM, ListMovieCharacters>();

        CreateMap<PageListResult<CharacterVM>, PageListResult<Character>>();
        CreateMap<PageListResult<CharacterVM>, PageListResult<ListPlanetCharacter>>();
        CreateMap<PageListResult<CharacterVM>, PageListResult<ListCharacters>>();
        CreateMap<PageListResult<CharacterVM>, PageListResult<ListMovieCharacters>>();
    }
}
