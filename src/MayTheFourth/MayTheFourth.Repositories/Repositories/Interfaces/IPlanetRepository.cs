using MayTheFourth.Entities;

namespace MayTheFourth.Repositories.Repositories.Interfaces;

public interface IPlanetRepository :
    IBaseReaderRepository<Planet>,
    IBaseWriterRepository<Planet>
{
}
