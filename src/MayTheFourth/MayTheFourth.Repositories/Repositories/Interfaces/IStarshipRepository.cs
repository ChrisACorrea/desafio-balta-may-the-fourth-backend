using MayTheFourth.Entities;

namespace MayTheFourth.Repositories.Repositories.Interfaces
{
    public interface IStarshipRepository :
        IBaseReaderRepository<Starship>,
        IBaseWriterRepository<Starship>
    {
    }
}
