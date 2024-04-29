using Bogus;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;
using NetSwissTools.System;

namespace MayTheFourth.Tests.ViewModels
{
    public class MovieVMTests
    {
        private readonly Faker<MovieVM> MovieFaker = new Faker<MovieVM>("pt_BR")
            .RuleFor(u => u.Id, g => g.Random.Guid())
            .RuleFor(u => u.Title, g => string.Join(" ", g.Lorem.Words(3)))
            .RuleFor(u => u.Episode, g => g.Random.Int(1, 10))
            .RuleFor(u => u.OpeningCrawl, g => string.Join(" ", g.Lorem.Paragraphs(10)))
            .RuleFor(u => u.Director, g => g.Name.FullName())
            .RuleFor(u => u.Producer, g => g.Name.FullName())
            .RuleFor(u => u.ReleaseDate, g => g.Date.PastDateOnly().ToDateTime())
            .RuleFor(u => u.CreatedAt, g => DateTime.Now)
            .RuleFor(u => u.UpdatedAt, g => DateTime.Now);

        [Fact]
        public void ShouldBeValidMovie()
        {
            var Movie = MovieFaker.Generate();

            Movie.ValidateAndCheck(
                Utils.Properties.Resources.Success);
        }

        [Fact]
        public void ShouldBeInvalidMovie()
        {
            var Movie = MovieFaker.Generate();
            Movie.Title = string.Empty;

            Movie.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.TitleIsRequired);

            Movie = MovieFaker.Generate();
            Movie.Episode = null;

            Movie.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.EpisodeIsRequired);
            
            Movie.Episode = -1;

            Movie.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.EpisodeIsRequired);

            Movie = MovieFaker.Generate();
            Movie.OpeningCrawl = string.Empty;

            Movie.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.OpeningCrawlIsRequired);

            Movie = MovieFaker.Generate();
            Movie.Director = string.Empty;

            Movie.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.DirectorIsRequired);

            Movie = MovieFaker.Generate();
            Movie.Producer = string.Empty;

            Movie.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.ProducerIsRequired);

            Movie = MovieFaker.Generate();
            Movie.ReleaseDate = null;

            Movie.ValidateAndCheck(
               Utils.Validation.ValidationModelResult.Warning,
               Utils.Properties.Resources.ReleaseDateIsRequired);

            Movie = MovieFaker.Generate();
            Movie.Title = string.Empty;
            Movie.Episode = null;
            Movie.OpeningCrawl = string.Empty;
            Movie.Director = string.Empty;
            Movie.Producer = string.Empty;
            Movie.ReleaseDate = null;

            Movie.IsValid().Check(Utils.Validation.ValidationModelResult.Warning, 6);
        }
    }
}
