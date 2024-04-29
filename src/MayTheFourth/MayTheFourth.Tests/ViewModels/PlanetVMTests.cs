using Bogus;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Tests.ViewModels
{
    public class PlanetVMTests
    {
        private readonly Faker<PlanetVM> PlanetFaker = new Faker<PlanetVM>("pt_BR")
            .RuleFor(u => u.Id, g => g.Random.Guid())
            .RuleFor(u => u.CreatedAt, g => DateTime.Now)
            .RuleFor(u => u.UpdatedAt, g => DateTime.Now);


        [Fact]
        public void ShouldBeValidPlanet()
        {
            var Planet = PlanetFaker.Generate();

            Planet.ValidateAndCheck(
                Utils.Properties.Resources.Success);
        }

        [Fact]
        public void ShouldBeInvalidPlanet()
        {
        }
    }
}
