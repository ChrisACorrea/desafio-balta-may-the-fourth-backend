using MayTheFourth.Entities;
using MayTheFourth.Repositories.Context;
using MayTheFourth.Repositories.Repositories.Interfaces;

namespace MayTheFourth.Repositories.Repositories;

public class CharacterRepository(DatabaseContext context) :
    BaseRepository<Character>(context),
    ICharacterRepository
{
}
