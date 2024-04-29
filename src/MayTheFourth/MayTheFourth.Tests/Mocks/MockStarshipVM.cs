using Bogus;
using MayTheFourth.Services.ViewModels;

namespace MayTheFourth.Tests.Mocks;

public static class MockStarshipVM
{
    public static Faker<StarshipVM> CreateFaker() =>
        new Faker<StarshipVM>("pt_BR")
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
}