using MayTheFourth.Entities;
using MayTheFourth.Repositories.Repositories.Interfaces;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Services;

public class CharacterService(ICharacterRepository repository) :
    BaseService<CharacterVM, Character>(repository, repository),
    ICharacterService
{
}
