using MayTheFourth.Entities;
using MayTheFourth.Repositories.Context;
using MayTheFourth.Repositories.Repositories.Interfaces;

namespace MayTheFourth.Repositories.Repositories
{
    public class StarshipRepository(DatabaseContext context) :
        BaseRepository<Starship>(context),
        IStarshipRepository
    {
    }
}
