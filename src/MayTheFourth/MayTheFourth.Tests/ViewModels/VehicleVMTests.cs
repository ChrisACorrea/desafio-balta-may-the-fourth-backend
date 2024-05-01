using Bogus;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;
using MayTheFourth.Tests.Mocks;

namespace MayTheFourth.Tests.ViewModels;

public class VehicleVMTests
{
   private readonly Faker<VehicleVM> _vehicleFaker = MockVehicleVM.CreateFaker();

   [Fact]
   public void ShouldBeValidVehicle()
   {
      var vehicle = _vehicleFaker.Generate();

      vehicle.ValidateAndCheck(
         Utils.Properties.Resources.Success);
   }

   [Fact]
   public void ShouldBeInvalidVehicle()
   {
      var vehicle = _vehicleFaker.Generate();
      vehicle.Name = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.NameIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.Model = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.ModelIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.Manufacturer = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.ManufacturerIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.CostInCredits = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.CostInCreditsIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.Length = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.LengthIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.MaxSpeed = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.MaxSpeedIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.Crew = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.CrewIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.Passengers = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.PassengersIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.CargoCapacity = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.CargoCapacityIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.Consumables = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.ConsumablesIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.Class = string.Empty;

      vehicle.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.ClassIsRequired);

      vehicle = _vehicleFaker.Generate();
      vehicle.Name = string.Empty;
      vehicle.Model = string.Empty;
      vehicle.Manufacturer = string.Empty;
      vehicle.CostInCredits = string.Empty;
      vehicle.Length = string.Empty;
      vehicle.MaxSpeed = string.Empty;
      vehicle.Crew = string.Empty;
      vehicle.Passengers = string.Empty;
      vehicle.CargoCapacity = string.Empty;
      vehicle.Consumables = string.Empty;
      vehicle.Class = string.Empty;

      vehicle.IsValid().Check(Utils.Validation.ValidationModelResult.Warning, 11);
   }
}

