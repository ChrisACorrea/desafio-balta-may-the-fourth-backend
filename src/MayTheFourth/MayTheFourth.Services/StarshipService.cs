using MayTheFourth.Entities;
using MayTheFourth.Repositories.Repositories.Interfaces;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Services;

public class StarshipService(IStarshipRepository repository) :
    BaseService<StarshipVM, Starship>(repository, repository),
    IStarshipService
{
}
