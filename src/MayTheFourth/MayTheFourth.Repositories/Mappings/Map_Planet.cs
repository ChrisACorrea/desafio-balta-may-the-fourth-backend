using MayTheFourth.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFourth.Repositories.Mappings
{
    internal class Map_Planet : BaseMappings<Planet>
    {
        public override void Configure(EntityTypeBuilder<Planet> builder)
        {
            base.Configure(builder);
            builder.ToTable("Planets");

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("VARCHAR(150)");
            builder.Property(c => c.RotationPeriod)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");
            builder.Property(c => c.OrbitalPeriod)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");
            builder.Property(c => c.Diameter)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");
            builder.Property(c => c.Climate)
                .IsRequired()
                .HasColumnType("VARCHAR(120)");
            builder.Property(c => c.Gravity)
                .IsRequired()
                .HasColumnType("VARCHAR(120)");
            builder.Property(c => c.Terrain)
                .IsRequired()
                .HasColumnType("VARCHAR(150)");
            builder.Property(c => c.SurfaceWater)
                .IsRequired()
                .HasColumnType("VARCHAR(120)");
            builder.Property(c => c.Population)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");

            builder.HasMany(c => c.Characters)
                .WithOne(c => c.Planet)
                .HasForeignKey(c => c.PlanetId);

            builder.HasMany(c => c.Movies)
                .WithMany(c => c.Planets);
        }
    }
}
