using MayTheFourth.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFourth.Repositories.Mappings
{
    internal class Map_Character : BaseMappings<Character>
    {
        public override void Configure(EntityTypeBuilder<Character> builder)
        {
            base.Configure(builder);
            builder.ToTable("Characters");

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("VARCHAR(150)");
            builder.Property(c => c.Height)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");
            builder.Property(c => c.Weight)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");
            builder.Property(c => c.HairColor)
                .IsRequired()
                .HasColumnType("VARCHAR(50)");
            builder.Property(c => c.SkinColor)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");
            builder.Property(c => c.EyeColor)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");
            builder.Property(c => c.BirthYear)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");
            builder.Property(c => c.Gender)
                .IsRequired()
                .HasColumnType("VARCHAR(20)");

            builder.HasOne(c => c.Planet)
                .WithMany(p => p.Characters)
                .HasForeignKey(c => c.PlanetId);

            builder.HasMany(c => c.Movies)
                .WithMany(c => c.Characters);
        }
    }
}
