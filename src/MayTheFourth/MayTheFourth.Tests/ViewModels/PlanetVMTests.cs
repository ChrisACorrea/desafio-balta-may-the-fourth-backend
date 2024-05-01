using Bogus;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Tests.Helpers;
using MayTheFourth.Tests.Mocks;

namespace MayTheFourth.Tests.ViewModels;

public class PlanetVMTests
{
    private readonly Faker<PlanetVM> _planetFaker = MockPlanetVM.CreateFaker();

    [Fact]
    public void ShouldBeValidPlanet()
    {
        var planet = _planetFaker.Generate();

        planet.ValidateAndCheck(
            Utils.Properties.Resources.Success);
    }

    [Fact]
    public void ShouldBeInvalidPlanet()
    {
        var planet = _planetFaker.Generate();
        planet.Name = string.Empty;

        planet.ValidateAndCheck(
            Utils.Validation.ValidationModelResult.Warning,
            Utils.Properties.Resources.NameIsRequired);
        
        planet = _planetFaker.Generate();
        planet.RotationPeriod = string.Empty;

        planet.ValidateAndCheck(
            Utils.Validation.ValidationModelResult.Warning,
            Utils.Properties.Resources.RotationPeriodIsRequired);
        
        planet = _planetFaker.Generate();
        planet.OrbitalPeriod = string.Empty;

        planet.ValidateAndCheck(
            Utils.Validation.ValidationModelResult.Warning,
            Utils.Properties.Resources.OrbitalPeriodIsRequired);
        
        planet = _planetFaker.Generate();
        planet.Diameter = string.Empty;

        planet.ValidateAndCheck(
            Utils.Validation.ValidationModelResult.Warning,
            Utils.Properties.Resources.DiameterIsRequired);
        
        planet = _planetFaker.Generate();
        planet.Climate = string.Empty;

        planet.ValidateAndCheck(
            Utils.Validation.ValidationModelResult.Warning,
            Utils.Properties.Resources.ClimateIsRequired);
        
        planet = _planetFaker.Generate();
        planet.Gravity = string.Empty;

        planet.ValidateAndCheck(
            Utils.Validation.ValidationModelResult.Warning,
            Utils.Properties.Resources.GravityIsRequired);
        
        planet = _planetFaker.Generate();
        planet.Terrain = string.Empty;

        planet.ValidateAndCheck(
            Utils.Validation.ValidationModelResult.Warning,
            Utils.Properties.Resources.TerrainIsRequired);
        
        planet = _planetFaker.Generate();
        planet.SurfaceWater = string.Empty;

        planet.ValidateAndCheck(
            Utils.Validation.ValidationModelResult.Warning,
            Utils.Properties.Resources.SurfaceWaterIsRequired);
        
        planet = _planetFaker.Generate();
        planet.Population = string.Empty;

        planet.ValidateAndCheck(
            Utils.Validation.ValidationModelResult.Warning,
            Utils.Properties.Resources.PopulationIsRequired);
        
        planet = _planetFaker.Generate();
        planet.Name = string.Empty;
        planet.RotationPeriod = string.Empty;
        planet.OrbitalPeriod = string.Empty;
        planet.Diameter = string.Empty;
        planet.Climate = string.Empty;
        planet.Gravity = string.Empty;
        planet.Terrain = string.Empty;
        planet.SurfaceWater = string.Empty;
        planet.Population = string.Empty;

        planet.IsValid().Check(Utils.Validation.ValidationModelResult.Warning, 9);
    }
}
