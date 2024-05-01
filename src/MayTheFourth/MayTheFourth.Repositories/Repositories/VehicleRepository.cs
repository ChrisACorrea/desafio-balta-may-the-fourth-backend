using MayTheFourth.Entities;
using MayTheFourth.Repositories.Context;
using MayTheFourth.Repositories.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MayTheFourth.Repositories.Repositories
{
    public class VehicleRepository(DatabaseContext context) :
        BaseRepository<Vehicle>(context),
        IVehicleRepository
    {
        public override IQueryable<Vehicle> GetDbSet(DbSet<Vehicle> pDbEntity)
        {
            return pDbEntity
                .Include(c => c.Movies)
                .AsQueryable();
        }
    }
}
