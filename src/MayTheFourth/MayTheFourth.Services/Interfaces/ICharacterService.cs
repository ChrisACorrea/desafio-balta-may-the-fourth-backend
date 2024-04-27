using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Services.Interfaces;
public interface ICharacterService :
    IBaseReaderService<CharacterVM, Character>,
    IBaseWriterService<CharacterVM, Character>,
    IErrorBaseService
{
}
