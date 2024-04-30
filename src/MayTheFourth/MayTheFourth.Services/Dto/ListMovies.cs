namespace MayTheFourth.Services.Dto;

public record ListMovies : IResultValues
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string Title { get; set; } = string.Empty;
    public int? Episode { get; set; }
    public string OpeningCrawl { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Producer { get; set; } = string.Empty;
    public DateTime? ReleaseDate { get; set; }

    public ListMovieCharacters[] Characters { get; set; } = [];
    public ListMoviePlanets[] Planets { get; set; } = [];
    public ListMovieVehicles[] Vehicles { get; set; } = [];
    public ListMovieStarships[] Starships { get; set; } = [];
}
