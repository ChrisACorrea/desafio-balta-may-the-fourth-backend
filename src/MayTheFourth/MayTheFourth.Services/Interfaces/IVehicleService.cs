using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Services.Interfaces;
public interface IVehicleService :
    IBaseReaderService<VehicleVM, Vehicle>,
    IBaseWriterService<VehicleVM, Vehicle>,
    IErrorBaseService
{
}
