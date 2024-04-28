using MayTheFourth.Repositories.Context;
using MayTheFourth.Repositories.Repositories;
using MayTheFourth.Repositories.Repositories.Interfaces;
using MayTheFourth.Services;
using MayTheFourth.Services.Interfaces;
using MayTheFourth.Services.Mappers.Profiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MayTheFourth.IoC
{
    public static class IocServices
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString(configuration["DefaultConnectionString"] ?? "");
            services.AddDbContextFactory<DatabaseContext>(options =>
                options.UseNpgsql(connectionString)
            );
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            services.AddAutoMapper(typeof(ModelToViewMovieProfile));
            services.AddAutoMapper(typeof(ViewToModelMovieProfile));
            services.AddAutoMapper(typeof(ModelToViewCharacterProfile));
            services.AddAutoMapper(typeof(ViewToModelCharacterProfile));

            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<ICharacterRepository, CharacterRepository>();

            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<ICharacterService, CharacterService>();

        }
    }
}
