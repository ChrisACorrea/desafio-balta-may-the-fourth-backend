using Bogus;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Tests.Mocks;

public static class MockPlanetVM
{
    public static Faker<PlanetVM> CreateFaker() =>
        new Faker<PlanetVM>("pt_BR")
            .RuleFor(u => u.Id, g => g.Random.Guid())
            .RuleFor(u => u.Name, g => g.Name.FullName())
            .RuleFor(u => u.RotationPeriod, g => $"{g.Random.Int(1, 4000)} days")
            .RuleFor(u => u.OrbitalPeriod, g => $"{g.Random.Int(1, 4000)} days")
            .RuleFor(u => u.Diameter, g => $"{g.Random.Int(10000, 300000)} KM")
            .RuleFor(u => u.Climate, g => g.Lorem.Word())
            .RuleFor(u => u.Gravity, g => g.Lorem.Word())
            .RuleFor(u => u.Terrain, g => g.Lorem.Word())
            .RuleFor(u => u.SurfaceWater, g => g.Lorem.Word())
            .RuleFor(u => u.Population, g => $"{g.Random.Int(1000, 300000)}")
            .RuleFor(u => u.CreatedAt, g => DateTime.Now)
            .RuleFor(u => u.UpdatedAt, g => DateTime.Now);
}