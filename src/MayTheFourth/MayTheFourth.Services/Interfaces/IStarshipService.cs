using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Services.Interfaces;
public interface IStarshipService :
    IBaseReaderService<StarshipVM, Starship>,
    IBaseWriterService<StarshipVM, Starship>,
    IErrorBaseService
{
}
