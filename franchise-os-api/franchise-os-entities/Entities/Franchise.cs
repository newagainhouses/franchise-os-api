namespace FranchiseOs.Entities.Entities;

/// <summary>
/// Placeholder entity demonstrating the expected shape. Replace / extend with
/// the real domain model.
/// </summary>
public class Franchise
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
