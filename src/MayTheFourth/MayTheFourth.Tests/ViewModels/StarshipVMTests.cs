using Bogus;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;
using MayTheFourth.Tests.Mocks;

namespace MayTheFourth.Tests.ViewModels;

public class StarshipVMTests
{
   private readonly Faker<StarshipVM> _starshipFaker = MockStarshipVM.CreateFaker();

   [Fact]
   public void ShouldBeValidStarship()
   {
      var starship = _starshipFaker.Generate();

      starship.ValidateAndCheck(
         Utils.Properties.Resources.Success);
   }

   [Fact]
   public void ShouldBeInvalidStarship()
   {
      var starship = _starshipFaker.Generate();
      starship.Name = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.NameIsRequired);

      starship = _starshipFaker.Generate();
      starship.Model = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.ModelIsRequired);

      starship = _starshipFaker.Generate();
      starship.Manufacturer = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.ManufacturerIsRequired);

      starship = _starshipFaker.Generate();
      starship.CostInCredits = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.CostInCreditsIsRequired);

      starship = _starshipFaker.Generate();
      starship.Length = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.LengthIsRequired);

      starship = _starshipFaker.Generate();
      starship.MaxSpeed = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.MaxSpeedIsRequired);

      starship = _starshipFaker.Generate();
      starship.Crew = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.CrewIsRequired);

      starship = _starshipFaker.Generate();
      starship.Passengers = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.PassengersIsRequired);

      starship = _starshipFaker.Generate();
      starship.CargoCapacity = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.CargoCapacityIsRequired);

      starship = _starshipFaker.Generate();
      starship.HyperdriveRating = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.HyperdriveRatingIsRequired);

      starship = _starshipFaker.Generate();
      starship.MGLT = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.MGLTIsRequired);

      starship = _starshipFaker.Generate();
      starship.Consumables = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.ConsumablesIsRequired);

      starship = _starshipFaker.Generate();
      starship.Class = string.Empty;

      starship.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.ClassIsRequired);

      starship = _starshipFaker.Generate();
      starship.Name = string.Empty;
      starship.Model = string.Empty;
      starship.Manufacturer = string.Empty;
      starship.CostInCredits = string.Empty;
      starship.Length = string.Empty;
      starship.MaxSpeed = string.Empty;
      starship.Crew = string.Empty;
      starship.Passengers = string.Empty;
      starship.CargoCapacity = string.Empty;
      starship.HyperdriveRating = string.Empty;
      starship.MGLT = string.Empty;
      starship.Consumables = string.Empty;
      starship.Class = string.Empty;

      starship.IsValid().Check(Utils.Validation.ValidationModelResult.Warning, 13);
   }
}

