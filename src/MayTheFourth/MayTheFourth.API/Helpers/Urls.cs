namespace MayTheFourth.API.Helpers;

public static class Urls
{
    public static string GetMoviesList => "/Movies/All";
    public static string GetMovieById => "/Movies/{Id}";
    public static string PostMovie => "/Movies";
    public static string PutMovieById => "/Movies/{Id}";
    public static string DeleteMovieById => "/Movies/{Id}";

    public static string GetCharactersList => "/Characters/All";
    public static string GetCharacterById => "/Characters/{Id}";
    public static string PostCharacter => "/Characters";
    public static string PutCharacterById => "/Characters/{Id}";
    public static string DeleteCharacterById => "/Characters/{Id}";

    public static string GetVehiclesList => "/Vehicles/All";
    public static string GetVehicleById => "/Vehicles/{Id}";
    public static string PostVehicle => "/Vehicles";
    public static string PutVehicleById => "/Vehicles/{Id}";
    public static string DeleteVehicleById => "/Vehicles/{Id}";

    public static string GetStarshipsList => "/Starships/All";
    public static string GetStarshipById => "/Starships/{Id}";
    public static string PostStarship => "/Starships";
    public static string PutStarshipById => "/Starships/{Id}";
    public static string DeleteStarshipById => "/Starships/{Id}";

    public static string GetPlanetsList => "/Planets/All";
    public static string GetPlanetById => "/Planets/{Id}";
    public static string PostPlanet => "/Planets";
    public static string PutPlanetById => "/Planets/{Id}";
    public static string DeletePlanetById => "/Planets/{Id}";
}

