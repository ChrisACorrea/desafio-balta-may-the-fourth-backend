using MayTheFourth.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFourth.Repositories.Mappings
{
    internal class Map_Vehicle: BaseMappings<Vehicle>
    {
        public override void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            base.Configure(builder);
            builder.ToTable("Vehicles");

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("VARCHAR(150)");
            builder.Property(c => c.Model)
                .IsRequired()
                .HasColumnType("VARCHAR(150)");
            builder.Property(c => c.Manufacturer)
                .IsRequired()
                .HasColumnType("VARCHAR(150)");
            builder.Property(c => c.CostInCredits)
                .IsRequired()
                .HasColumnType("VARCHAR(100)");
            builder.Property(c => c.Length)
                .IsRequired()
                .HasColumnType("VARCHAR(100)");
            builder.Property(c => c.MaxSpeed)
                .IsRequired()
                .HasColumnType("VARCHAR(100)");
            builder.Property(c => c.Crew)
                .IsRequired()
                .HasColumnType("VARCHAR(150)");
            builder.Property(c => c.Passengers)
                .IsRequired()
                .HasColumnType("VARCHAR(120)");
            builder.Property(c => c.CargoCapacity)
                .IsRequired()
                .HasColumnType("VARCHAR(120)");
            builder.Property(c => c.Consumables)
                .IsRequired()
                .HasColumnType("VARCHAR(120)");
            builder.Property(c => c.Class)
                .IsRequired()
                .HasColumnType("VARCHAR(120)");

            builder.HasMany(c => c.Movies)
                .WithMany(c => c.Vehicles);
        }
    }
}
