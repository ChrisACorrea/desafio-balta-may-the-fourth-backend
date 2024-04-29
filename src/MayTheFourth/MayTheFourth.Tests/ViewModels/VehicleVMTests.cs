using Bogus;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;

namespace MayTheFourth.Tests.ViewModels
{
    public class VehicleVMTests
    {
        private readonly Faker<VehicleVM> VehicleFaker = new Faker<VehicleVM>("pt_BR")
            .RuleFor(u => u.Id, g => g.Random.Guid())
            .RuleFor(u => u.Name, g => string.Join(" ", g.Lorem.Words(2)))
            .RuleFor(u => u.Model, g => string.Join(" ", g.Lorem.Words(2)))
            .RuleFor(u => u.Manufacturer, g => string.Join(" ", g.Lorem.Words(2)))
            .RuleFor(u => u.CostInCredits, g => $"{g.Random.Int(1, 1000):c2}")
            .RuleFor(u => u.Length, g => $"{g.Random.Int(1, 1000)} meters")
            .RuleFor(u => u.MaxSpeed, g => $"{g.Random.Int(1, 1000)} KM/H")
            .RuleFor(u => u.Crew, g => string.Join(" ", g.Lorem.Words(3)))
            .RuleFor(u => u.Passengers, g => $"{g.Random.Int(1, 1000)}")
            .RuleFor(u => u.CargoCapacity, g => $"{g.Random.Int(1, 3000)} Kg")
            .RuleFor(u => u.Consumables, g => string.Join(" ", g.Lorem.Words(2)))
            .RuleFor(u => u.Class, g => string.Join(" ", g.Lorem.Words(2)))
            .RuleFor(u => u.CreatedAt, g => DateTime.Now)
            .RuleFor(u => u.UpdatedAt, g => DateTime.Now);

        [Fact]
        public void ShouldBeValidVehicle()
        {
            var Vehicle = VehicleFaker.Generate();

            Vehicle.ValidateAndCheck(
                Utils.Properties.Resources.Success);
        }

        [Fact]
        public void ShouldBeInvalidVehicle()
        {
            var Vehicle = VehicleFaker.Generate();
            Vehicle.Name = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.NameIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.Model = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.ModelIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.Manufacturer = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.ManufacturerIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.CostInCredits = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.CostInCreditsIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.Length = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.LengthIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.MaxSpeed = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.MaxSpeedIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.Crew = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.CrewIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.Passengers = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.PassengersIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.CargoCapacity = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.CargoCapacityIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.Consumables = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.ConsumablesIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.Class = string.Empty;

            Vehicle.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.ClassIsRequired);

            Vehicle = VehicleFaker.Generate();
            Vehicle.Name = string.Empty;
            Vehicle.Model = string.Empty;
            Vehicle.Manufacturer = string.Empty;
            Vehicle.CostInCredits = string.Empty;
            Vehicle.Length = string.Empty;
            Vehicle.MaxSpeed = string.Empty;
            Vehicle.Crew = string.Empty;
            Vehicle.Passengers = string.Empty;
            Vehicle.CargoCapacity = string.Empty;
            Vehicle.Consumables = string.Empty;
            Vehicle.Class = string.Empty;

            Vehicle.IsValid().Check(Utils.Validation.ValidationModelResult.Warning, 11);
        }
    }
}
