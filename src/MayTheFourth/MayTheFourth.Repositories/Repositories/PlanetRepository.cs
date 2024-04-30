using MayTheFourth.Entities;
using MayTheFourth.Repositories.Context;
using MayTheFourth.Repositories.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Repositories.Repositories;

public class PlanetRepository(DatabaseContext context) :
    BaseRepository<Planet>(context),
    IPlanetRepository
{
    public override IQueryable<Planet> GetDbSet(DbSet<Planet> pDbEntity)
    {
        return pDbEntity
            .Include(c => c.Characters)
            .Include(c => c.Movies)
            .AsQueryable();
    }
}
