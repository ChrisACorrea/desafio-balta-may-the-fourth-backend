using MayTheFourth.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFourth.Repositories.Mappings
{
    internal class Map_Movie : BaseMappings<Movie>
    {
        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            base.Configure(builder);
            builder.ToTable("Movies");

            builder.Property(c => c.Title)
                .IsRequired()
                .HasColumnType("VARCHAR(150)");
            builder.Property(c => c.Episode)
                .IsRequired()
                .HasColumnType("INT4");
            builder.Property(c => c.OpeningCrawl)
                .IsRequired()
                .HasColumnType("VARCHAR(550)");
            builder.Property(c => c.Director)
                .IsRequired()
                .HasColumnType("VARCHAR(150)");
            builder.Property(c => c.Producer)
                .IsRequired()
                .HasColumnType("VARCHAR(150)");
            builder.Property(c => c.ReleaseDate)
                .IsRequired()
                .HasColumnType("DATE");

            builder.HasMany(c => c.Characters)
                .WithMany(c => c.Movies);

            builder.HasMany(c => c.Planets)
                .WithMany(c => c.Movies);

            builder.HasMany(c => c.Vehicles)
                .WithMany(c => c.Movies);

            builder.HasMany(c => c.Starships)
                .WithMany(c => c.Movies);
        }
    }
}
