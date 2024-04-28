using MayTheFourth.Entities;
using MayTheFourth.Utils.Validation;

namespace MayTheFourth.Services.ViewModels;

public class VehicleVM : BaseViewModel<Vehicle>
{
    public VehicleVM()
    {
        Movies = [];
    }

    public string Name { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public string CostInCredits { get; set; } = string.Empty;
    public string Length { get; set; } = string.Empty;
    public string MaxSpeed { get; set; } = string.Empty;
    public string Crew { get; set; } = string.Empty;
    public string Passengers { get; set; } = string.Empty;
    public string CargoCapacity { get; set; } = string.Empty;
    public string Consumables { get; set; } = string.Empty;
    public string Class { get; set; } = string.Empty;
    public ICollection<Movie> Movies { get; set; }

    public override Vehicle GetEntity() =>
        new()
        {
            Id = Id,
            Name = Name,
            Model = Model,
            Manufacturer = Manufacturer,
            CostInCredits = CostInCredits,
            Length = Length,
            MaxSpeed = MaxSpeed,
            Crew = Crew,
            Passengers = Passengers,
            CargoCapacity = CargoCapacity,
            Consumables = Consumables,
            Class = Class,
            Movies = Movies
        };

    public override ValidationViewModel IsValid()
    {
        var resultMessages = new List<string>();
        if (string.IsNullOrEmpty(Name))
            resultMessages.Add(Utils.Properties.Resources.NameIsRequired);

        if (string.IsNullOrEmpty(Model))
            resultMessages.Add(Utils.Properties.Resources.ModelIsRequired);

        if (string.IsNullOrEmpty(Manufacturer))
            resultMessages.Add(Utils.Properties.Resources.ManufacturerIsRequired);

        if (string.IsNullOrEmpty(CostInCredits))
            resultMessages.Add(Utils.Properties.Resources.CostInCreditsIsRequired);

        if (string.IsNullOrEmpty(Length))
            resultMessages.Add(Utils.Properties.Resources.LengthIsRequired);

        if (string.IsNullOrEmpty(MaxSpeed))
            resultMessages.Add(Utils.Properties.Resources.MaxSpeedIsRequired);

        if (string.IsNullOrEmpty(Crew))
            resultMessages.Add(Utils.Properties.Resources.CrewIsRequired);

        if (string.IsNullOrEmpty(Passengers))
            resultMessages.Add(Utils.Properties.Resources.PassengersIsRequired);

        if (string.IsNullOrEmpty(CargoCapacity))
            resultMessages.Add(Utils.Properties.Resources.CargoCapacityIsRequired);

        if (string.IsNullOrEmpty(Consumables))
            resultMessages.Add(Utils.Properties.Resources.ConsumablesIsRequired);

        if (string.IsNullOrEmpty(Class))
            resultMessages.Add(Utils.Properties.Resources.ClassIsRequired);

        return resultMessages.Any() ?
            ValidationViewModel.Create(ValidationModelResult.Warning, resultMessages.ToArray()) :
            ValidationViewModel.Create(ValidationModelResult.Success);
    }
}
