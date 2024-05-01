using MayTheFourth.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MayTheFourth.Repositories.Mappings
{
    internal class BaseMappings<T> : IEntityTypeConfiguration<T> where T : BaseModel
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.ToTable(nameof(T));
            builder.HasKey(x => x.Id);
            builder.Property(c => c.Id)
                .ValueGeneratedNever();
            builder.Property(c => c.CreatedAt)
                .HasDefaultValueSql("NOW()")
                .IsRequired()
                .HasColumnType("DATE");
            builder.Property(c => c.UpdatedAt)
                .HasDefaultValueSql("NOW()")
                .IsRequired()
                .HasColumnType("DATE");
        }
    }
}
