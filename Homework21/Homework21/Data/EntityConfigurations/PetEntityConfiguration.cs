using Homework21.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Homework21.Data.EntityConfigurations
{
    public class PetEntityConfiguration : IEntityTypeConfiguration<PetEntity>
    {
        public void Configure(EntityTypeBuilder<PetEntity> builder)
        {
            builder.HasKey(h => h.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired();
            builder.Property(p => p.BreedId).IsRequired();
            builder.Property(p => p.Age).IsRequired();
            builder.Property(p => p.LocationId).IsRequired();
            builder.Property(p => p.ImageUrl).IsRequired();
            builder.Property(p => p.Description).IsRequired();

            builder.HasOne(h => h.Category)
                .WithMany(w => w.Pets)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(h => h.Breed)
                .WithMany(w => w.Pets)
                .HasForeignKey(h => h.BreedId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(h => h.Location)
                .WithMany(w => w.Pets)
                .HasForeignKey(h => h.LocationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
