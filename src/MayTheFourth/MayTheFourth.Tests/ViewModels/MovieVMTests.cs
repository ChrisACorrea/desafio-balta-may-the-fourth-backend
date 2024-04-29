using Bogus;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;
using MayTheFourth.Tests.Mocks;

namespace MayTheFourth.Tests.ViewModels;

public class MovieVMTests
{
   private readonly Faker<MovieVM> _movieFaker = MockMoviesVM.CreateFaker();

   [Fact]
   public void ShouldBeValidMovie()
   {
      var movie = _movieFaker.Generate();

      movie.ValidateAndCheck(
         Utils.Properties.Resources.Success);
   }

   [Fact]
   public void ShouldBeInvalidMovie()
   {
      var movie = _movieFaker.Generate();
      movie.Title = string.Empty;

      movie.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.TitleIsRequired);

      movie = _movieFaker.Generate();
      movie.Episode = null;

      movie.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.EpisodeIsRequired);

      movie.Episode = -1;

      movie.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.EpisodeIsRequired);

      movie = _movieFaker.Generate();
      movie.OpeningCrawl = string.Empty;

      movie.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.OpeningCrawlIsRequired);

      movie = _movieFaker.Generate();
      movie.Director = string.Empty;

      movie.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.DirectorIsRequired);

      movie = _movieFaker.Generate();
      movie.Producer = string.Empty;

      movie.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.ProducerIsRequired);

      movie = _movieFaker.Generate();
      movie.ReleaseDate = null;

      movie.ValidateAndCheck(
         Utils.Validation.ValidationModelResult.Warning,
         Utils.Properties.Resources.ReleaseDateIsRequired);

      movie = _movieFaker.Generate();
      movie.Title = string.Empty;
      movie.Episode = null;
      movie.OpeningCrawl = string.Empty;
      movie.Director = string.Empty;
      movie.Producer = string.Empty;
      movie.ReleaseDate = null;

      movie.IsValid().Check(Utils.Validation.ValidationModelResult.Warning, 6);
   }
}

