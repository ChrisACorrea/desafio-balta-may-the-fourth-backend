using MayTheFourth.Entities;
using MayTheFourth.Repositories.Context;
using MayTheFourth.Repositories.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Repositories.Repositories
{
    public class MovieRepository(DatabaseContext context) :
        BaseRepository<Movie>(context),
        IMovieRepository
    {
        public override IQueryable<Movie> GetDbSet(DbSet<Movie> pDbEntity)
        {
            return pDbEntity
                .Include(c => c.Characters)
                .Include(c => c.Planets)
                .Include(c => c.Vehicles)
                .Include(c => c.Starships);
        }
    }
}
