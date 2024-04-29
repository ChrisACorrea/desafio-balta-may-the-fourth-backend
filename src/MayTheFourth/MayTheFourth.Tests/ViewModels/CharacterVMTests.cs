using Bogus;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;
using MayTheFourth.Tests.Mocks;

namespace MayTheFourth.Tests.ViewModels;

public class CharacterVMTests
{
   private readonly Faker<CharacterVM> _faker = MockCharacterVM.CreateFaker();

   [Fact]
   public void ShouldBeValidCharacter()
   {
      var character = _faker.Generate();

      character.ValidateAndCheck(
         Utils.Properties.Resources.Success);
   }

   [Fact]
   public void ShouldBeInvalidCharacter()
   {
      var character = _faker.Generate();
      character.Name = string.Empty;

      character.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.NameIsRequired);

      character = _faker.Generate();
      character.Height = string.Empty;

      character.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.HeightIsRequired);

      character = _faker.Generate();
      character.Weight = string.Empty;

      character.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.WeightIsRequired);

      character = _faker.Generate();
      character.HairColor = string.Empty;

      character.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.HairColorIsRequired);

      character = _faker.Generate();
      character.SkinColor = string.Empty;

      character.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.SkinColorIsRequired);

      character = _faker.Generate();
      character.EyeColor = string.Empty;

      character.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.EyeColorIsRequired);

      character = _faker.Generate();
      character.BirthYear = string.Empty;

      character.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.BirthYearIsRequired);

      character = _faker.Generate();
      character.Gender = string.Empty;

      character.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.GenderIsRequired);

      character = _faker.Generate();
      character.PlanetId = null;

      character.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.PlanetIdIsRequired);

      character.PlanetId = Guid.Empty;

      character.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.PlanetIdIsRequired);

      character = _faker.Generate();
      character.Name = string.Empty;
      character.Height = string.Empty;
      character.Weight = string.Empty;
      character.HairColor = string.Empty;
      character.SkinColor = string.Empty;
      character.EyeColor = string.Empty;
      character.BirthYear = string.Empty;
      character.Gender = string.Empty;
      character.PlanetId = Guid.Empty;

      character.IsValid().Check(Utils.Validation.ValidationModelResult.Warning, 9);
   }
}

