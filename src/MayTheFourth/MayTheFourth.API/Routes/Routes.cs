namespace MayTheFourth.API.Routes;

public static class Routes
{
    public static void MapRoutes(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", context =>
        {
            context.Response.Redirect("/swagger/");
            return Task.CompletedTask;
        });

        app.MapCharactersRoutes();
        app.MapMoviesRoutes();
        app.MapVehiclesRoutes();
    }
}
