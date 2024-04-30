using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFourth.Services.Dto;

public record ListVehicles : IResultValues
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
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
    public ListVehicleMovies[] Movies { get; set; }

}
