using Bogus;
using MayTheFourth.Entities;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Tests.ViewModels
{
    public class CharacterVMTests
    {
        private readonly Faker<CharacterVM> CharacterFaker = new Faker<CharacterVM>("pt_BR")
            .RuleFor(u => u.Id, g => g.Random.Guid())
            .RuleFor(u => u.Name, g => g.Name.FindName())
            .RuleFor(u => u.Height, g => $"{g.Random.Int(1, 4)} meters")
            .RuleFor(u => u.Weight, g => $"{g.Random.Int(1, 200)} Kg")
            .RuleFor(u => u.HairColor, g => g.Lorem.Word())
            .RuleFor(u => u.SkinColor, g => g.Lorem.Word())
            .RuleFor(u => u.EyeColor, g => g.Lorem.Word())
            .RuleFor(u => u.BirthYear, g => g.Date.Past().Year.ToString())
            .RuleFor(u => u.Gender, g => g.Person.Gender.ToString())
            .RuleFor(u => u.PlanetId, g => g.Random.Guid())
            .RuleFor(u => u.CreatedAt, g => DateTime.Now)
            .RuleFor(u => u.UpdatedAt, g => DateTime.Now);


        [Fact]
        public void ShouldBeValidCharacter()
        {
            var Character = CharacterFaker.Generate();

            Character.ValidateAndCheck(
                Utils.Properties.Resources.Success);
        }

        [Fact]
        public void ShouldBeInvalidCharacter()
        {
            var Character = CharacterFaker.Generate();
            Character.Name = string.Empty;

            Character.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.NameIsRequired);

            Character = CharacterFaker.Generate();
            Character.Height = string.Empty;

            Character.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.HeightIsRequired);

            Character = CharacterFaker.Generate();
            Character.Weight = string.Empty;

            Character.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.WeightIsRequired);

            Character = CharacterFaker.Generate();
            Character.HairColor = string.Empty;

            Character.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.HairColorIsRequired);

            Character = CharacterFaker.Generate();
            Character.SkinColor = string.Empty;

            Character.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.SkinColorIsRequired);

            Character = CharacterFaker.Generate();
            Character.EyeColor = string.Empty;

            Character.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.EyeColorIsRequired);

            Character = CharacterFaker.Generate();
            Character.BirthYear = string.Empty;

            Character.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.BirthYearIsRequired);

            Character = CharacterFaker.Generate();
            Character.Gender = string.Empty;

            Character.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.GenderIsRequired);

            Character = CharacterFaker.Generate();
            Character.PlanetId = null;

            Character.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.PlanetIdIsRequired);

            Character.PlanetId = Guid.Empty;

            Character.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.PlanetIdIsRequired);

            Character = CharacterFaker.Generate();
            Character.Name = string.Empty;
            Character.Height = string.Empty;
            Character.Weight = string.Empty;
            Character.HairColor = string.Empty;
            Character.SkinColor = string.Empty;
            Character.EyeColor = string.Empty;
            Character.BirthYear = string.Empty;
            Character.Gender = string.Empty;
            Character.PlanetId = Guid.Empty;

            Character.IsValid().Check(Utils.Validation.ValidationModelResult.Warning, 9);
        }
    }
}
