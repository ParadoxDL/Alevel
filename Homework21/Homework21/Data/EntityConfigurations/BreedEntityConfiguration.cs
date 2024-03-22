using Homework21.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework21.Data.EntityConfigurations
{
    public class BreedEntityConfiguration : IEntityTypeConfiguration<BreedEntity>
    {
        public void Configure(EntityTypeBuilder<BreedEntity> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.BreedName).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired();

            builder.HasOne(h => h.Category)
                .WithMany(w => w.Breeds)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
