using MayTheFourth.Entities;

namespace MayTheFourth.Repositories.Repositories.Interfaces;
public interface ICharacterRepository :
    IBaseReaderRepository<Character>,
    IBaseWriterRepository<Character>
{
}
