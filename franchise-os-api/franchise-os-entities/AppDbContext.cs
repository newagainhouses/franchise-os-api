using FranchiseOs.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace FranchiseOs.Entities;

/// <summary>
/// Primary EF Core <see cref="DbContext"/> for the Franchise OS data model.
/// This library is intended to be referenced by multiple projects (API, workers,
/// background jobs, etc.) so it should remain free of project-specific concerns.
/// </summary>
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Add DbSet<T> properties for each aggregate root / entity here.
    public DbSet<Franchise> Franchises => Set<Franchise>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply all IEntityTypeConfiguration<T> implementations in this assembly.
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
