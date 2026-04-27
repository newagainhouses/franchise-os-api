using FranchiseOs.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FranchiseOs.Entities.Configurations;

/// <summary>
/// Example Fluent API configuration. Add one of these per entity that needs
/// non-conventional mapping.
/// </summary>
public class FranchiseConfiguration : IEntityTypeConfiguration<Franchise>
{
    public void Configure(EntityTypeBuilder<Franchise> builder)
    {
        builder.ToTable("franchises");

        builder.HasKey(f => f.Id);

        builder.Property(f => f.Name)
            .IsRequired()
            .HasMaxLength(256);

        builder.Property(f => f.CreatedAt)
            .IsRequired();
    }
}
