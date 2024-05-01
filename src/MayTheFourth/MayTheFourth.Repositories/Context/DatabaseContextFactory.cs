using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MayTheFourth.Repositories.Context
{
    public class DatabaseContextFactory: IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

            var connectionString = args.Length > 0
                ? args[0]
                : "";
            
            if (args.Length <= 0)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                connectionString = configuration.GetConnectionString(configuration["DefaultConnectionString"] ?? "");
            }

            optionsBuilder.UseNpgsql(connectionString);

            return new DatabaseContext(optionsBuilder.Options);
        }

        public void Migrate(DatabaseContext context, bool clearDatabase)
        {
            if (clearDatabase)
                context.Database.EnsureDeleted();
            
            context.Database.Migrate();
        }
    }
}
