namespace MayTheFourth.API.Routes;

public static class Routes
{
    public static void MapRoutes(this IEndpointRouteBuilder app)
    {
        app.MapCharactersRoutes();
    }
}
