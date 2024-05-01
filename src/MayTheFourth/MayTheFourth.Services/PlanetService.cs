using MayTheFourth.Entities;
using MayTheFourth.Repositories.Repositories.Interfaces;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Services;

public class PlanetService(IPlanetRepository repository) :
    BaseService<PlanetVM, Planet>(repository, repository),
    IPlanetService
{
}
