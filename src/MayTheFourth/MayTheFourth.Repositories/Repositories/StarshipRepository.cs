using MayTheFourth.Entities;
using MayTheFourth.Repositories.Context;
using MayTheFourth.Repositories.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Repositories.Repositories
{
    public class StarshipRepository(DatabaseContext context) :
        BaseRepository<Starship>(context),
        IStarshipRepository
    {
        public override IQueryable<Starship> GetDbSet(DbSet<Starship> pDbEntity)
        {
            return pDbEntity
                .Include(c => c.Movies)
                .AsQueryable();
        }
    }
}
