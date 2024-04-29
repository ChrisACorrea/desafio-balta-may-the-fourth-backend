using MayTheFourth.Entities;
using MayTheFourth.Utils.Validation;

namespace MayTheFourth.Services.ViewModels;

public class PlanetVM : BaseViewModel<Planet>
{
    public PlanetVM()
    {
        Movies = [];
        Characters = [];
    }

    public string Name { get; set; } = string.Empty;
    public string RotationPeriod { get; set; } = string.Empty;
    public string OrbitalPeriod { get; set; } = string.Empty;
    public string Diameter { get; set; } = string.Empty;
    public string Climate { get; set; } = string.Empty;
    public string Gravity { get; set; } = string.Empty;
    public string Terrain { get; set; } = string.Empty;
    public string SurfaceWater { get; set; } = string.Empty;
    public string Population { get; set; } = string.Empty;

    public ICollection<Character> Characters { get; set; }
    public ICollection<Movie> Movies { get; set; }

    public override Planet GetEntity() =>
        new()
        {
            Id = Id,
            Name = Name,
            RotationPeriod = RotationPeriod,
            OrbitalPeriod = OrbitalPeriod,
            Diameter = Diameter,
            Climate = Climate,
            Gravity = Gravity,
            Terrain = Terrain,
            SurfaceWater = SurfaceWater,
            Population = Population,
            Characters = Characters,
            Movies = Movies
        };

    public override ValidationViewModel IsValid()
    {
        var resultMessages = new List<string>();
        if (string.IsNullOrEmpty(Name))
            resultMessages.Add(Utils.Properties.Resources.NameIsRequired);

        if (string.IsNullOrEmpty(RotationPeriod))
            resultMessages.Add(Utils.Properties.Resources.RotationPeriodIsRequired);

        if (string.IsNullOrEmpty(OrbitalPeriod))
            resultMessages.Add(Utils.Properties.Resources.OrbitalPeriodIsRequired);

        if (string.IsNullOrEmpty(Diameter))
            resultMessages.Add(Utils.Properties.Resources.DiameterIsRequired);

        if (string.IsNullOrEmpty(Climate))
            resultMessages.Add(Utils.Properties.Resources.ClimateIsRequired);

        if (string.IsNullOrEmpty(Gravity))
            resultMessages.Add(Utils.Properties.Resources.GravityIsRequired);

        if (string.IsNullOrEmpty(Terrain))
            resultMessages.Add(Utils.Properties.Resources.TerrainIsRequired);

        if (string.IsNullOrEmpty(SurfaceWater))
            resultMessages.Add(Utils.Properties.Resources.SurfaceWaterIsRequired);

        if (string.IsNullOrEmpty(Population))
            resultMessages.Add(Utils.Properties.Resources.PopulationIsRequired);

        return resultMessages.Any() ?
            ValidationViewModel.Create(ValidationModelResult.Warning, resultMessages.ToArray()) :
            ValidationViewModel.Create(ValidationModelResult.Success);
    }
}
