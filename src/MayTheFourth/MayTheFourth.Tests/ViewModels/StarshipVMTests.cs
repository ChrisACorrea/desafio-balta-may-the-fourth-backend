using Bogus;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;

namespace MayTheFourth.Tests.ViewModels
{
    public class StarshipVMTests
    {
        private readonly Faker<StarshipVM> StarshipFaker = new Faker<StarshipVM>("pt_BR")
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
            .RuleFor(u => u.HyperdriveRating, g => $"{g.Random.Int(1, 10)}")
            .RuleFor(u => u.MGLT, g => string.Join(" ", g.Lorem.Words(2)))
            .RuleFor(u => u.Consumables, g => string.Join(" ", g.Lorem.Words(2)))
            .RuleFor(u => u.Class, g => string.Join(" ", g.Lorem.Words(2)))
            .RuleFor(u => u.CreatedAt, g => DateTime.Now)
            .RuleFor(u => u.UpdatedAt, g => DateTime.Now);


        [Fact]
        public void ShouldBeValidStarship()
        {
            var Starship = StarshipFaker.Generate();

            Starship.ValidateAndCheck(
                Utils.Properties.Resources.Success);
        }

        [Fact]
        public void ShouldBeInvalidStarship()
        {
            var Starship = StarshipFaker.Generate();
            Starship.Name = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.NameIsRequired);
            
            Starship = StarshipFaker.Generate();
            Starship.Model = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.ModelIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.Manufacturer = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.ManufacturerIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.CostInCredits = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.CostInCreditsIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.Length = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.LengthIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.MaxSpeed = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.MaxSpeedIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.Crew = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.CrewIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.Passengers = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.PassengersIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.CargoCapacity = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.CargoCapacityIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.HyperdriveRating = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.HyperdriveRatingIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.MGLT = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.MGLTIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.Consumables = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.ConsumablesIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.Class = string.Empty;

            Starship.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.ClassIsRequired);

            Starship = StarshipFaker.Generate();
            Starship.Name = string.Empty;
            Starship.Model = string.Empty;
            Starship.Manufacturer = string.Empty;
            Starship.CostInCredits = string.Empty;
            Starship.Length = string.Empty;
            Starship.MaxSpeed = string.Empty;
            Starship.Crew = string.Empty;
            Starship.Passengers = string.Empty;
            Starship.CargoCapacity = string.Empty;
            Starship.HyperdriveRating = string.Empty;
            Starship.MGLT = string.Empty;
            Starship.Consumables = string.Empty;
            Starship.Class = string.Empty;

            Starship.IsValid().Check(Utils.Validation.ValidationModelResult.Warning, 13);
        }
    }
}
