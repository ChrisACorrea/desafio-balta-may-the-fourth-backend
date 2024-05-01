using Bogus;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Tests.Mocks;

public static class MockCharacterVM
{
    public static Faker<CharacterVM> CreateFaker() =>
        new Faker<CharacterVM>("pt_BR")
            .RuleFor(u => u.Id, g => g.Random.Guid())
            .RuleFor(u => u.Name, g => g.Name.FullName())
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
}