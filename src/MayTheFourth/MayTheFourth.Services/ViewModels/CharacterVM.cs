using MayTheFourth.Entities;
using MayTheFourth.Utils.Validation;

namespace MayTheFourth.Services.ViewModels;

public class CharacterVM : BaseViewModel<Character>
{
    public CharacterVM()
    {
        Movies = [];
    }

    public string Name { get; set; } = string.Empty;
    public string Height { get; set; } = string.Empty;
    public string Weight { get; set; } = string.Empty;
    public string HairColor { get; set; } = string.Empty;
    public string SkinColor { get; set; } = string.Empty;
    public string EyeColor { get; set; } = string.Empty;
    public string BirthYear { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public Guid? PlanetId { get; set; }
    public Planet? Planet { get; set; }

    public ICollection<Movie> Movies { get; set; }

    public override Character GetEntity() =>
        new()
        {
            Id = Id,
            Name = Name,
            Height = Height,
            Weight = Weight,
            HairColor = HairColor,
            SkinColor = SkinColor,
            EyeColor = EyeColor,
            BirthYear = BirthYear,
            Gender = Gender,
            PlanetId = Planet?.Id ?? Guid.Empty,
            Planet = Planet,
            Movies = Movies
        };

    public override ValidationViewModel IsValid()
    {
        var resultMessages = new List<string>();
        if (string.IsNullOrEmpty(Name))
            resultMessages.Add(Utils.Properties.Resources.NameIsRequired);

        if (string.IsNullOrEmpty(Height))
            resultMessages.Add(Utils.Properties.Resources.HeightIsRequired);

        if (string.IsNullOrEmpty(Weight))
            resultMessages.Add(Utils.Properties.Resources.WeightIsRequired);

        if (string.IsNullOrEmpty(HairColor))
            resultMessages.Add(Utils.Properties.Resources.HairColorIsRequired);

        if (string.IsNullOrEmpty(SkinColor))
            resultMessages.Add(Utils.Properties.Resources.SkinColorIsRequired);

        if (string.IsNullOrEmpty(EyeColor))
            resultMessages.Add(Utils.Properties.Resources.EyeColorIsRequired);

        if (string.IsNullOrEmpty(BirthYear))
            resultMessages.Add(Utils.Properties.Resources.BirthYearIsRequired);

        if (string.IsNullOrEmpty(Gender))
            resultMessages.Add(Utils.Properties.Resources.GenderIsRequired);

        if (PlanetId is null || PlanetId == Guid.Empty)
            resultMessages.Add(Utils.Properties.Resources.PlanetIdIsRequired);

        return resultMessages.Any() ?
            ValidationViewModel.Create(ValidationModelResult.Warning, resultMessages.ToArray()) :
            ValidationViewModel.Create(ValidationModelResult.Success);
    }
}
