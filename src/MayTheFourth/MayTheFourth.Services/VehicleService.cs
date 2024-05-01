using MayTheFourth.Entities;
using MayTheFourth.Repositories.Repositories.Interfaces;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Services;

public class VehicleService(IVehicleRepository repository) :
    BaseService<VehicleVM, Vehicle>(repository, repository),
    IVehicleService
{
}
