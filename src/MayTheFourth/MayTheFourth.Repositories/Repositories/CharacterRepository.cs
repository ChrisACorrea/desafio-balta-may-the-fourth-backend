using MayTheFourth.Entities;
using MayTheFourth.Repositories.Context;
using MayTheFourth.Repositories.Repositories.Interfaces;
using MayTheFourth.Utils.Paging;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Repositories.Repositories;

public class CharacterRepository(DatabaseContext context) :
    BaseRepository<Character>(context),
    ICharacterRepository
{
    public override IQueryable<Character> GetDbSet(DbSet<Character> pDbEntity)
    {
        return pDbEntity
            .Include(c => c.Planet)
            .Include(c => c.Movies);
    }
}
