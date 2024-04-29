using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Services.Interfaces;

public interface IPlanetService :
    IBaseReaderService<PlanetVM, Planet>,
    IBaseWriterService<PlanetVM, Planet>,
    IErrorBaseService
{
}
