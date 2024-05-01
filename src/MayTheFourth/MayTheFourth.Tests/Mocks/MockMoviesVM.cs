using Bogus;
using MayTheFourth.Services.ViewModels;
using NetSwissTools.System;

namespace MayTheFourth.Tests.Mocks;

public static class MockMoviesVM
{
    public static Faker<MovieVM> CreateFaker() =>
        new Faker<MovieVM>("pt_BR")
        .RuleFor(u => u.Id, g => g.Random.Guid())
        .RuleFor(u => u.Title, g => string.Join(" ", g.Lorem.Words(3)))
        .RuleFor(u => u.Episode, g => g.Random.Int(1, 10))
        .RuleFor(u => u.OpeningCrawl, g => string.Join(" ", g.Lorem.Paragraphs(10)))
        .RuleFor(u => u.Director, g => g.Name.FullName())
        .RuleFor(u => u.Producer, g => g.Name.FullName())
        .RuleFor(u => u.ReleaseDate, g => g.Date.PastDateOnly().ToDateTime())
        .RuleFor(u => u.CreatedAt, g => DateTime.Now)
        .RuleFor(u => u.UpdatedAt, g => DateTime.Now);
}