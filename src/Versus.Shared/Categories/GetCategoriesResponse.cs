namespace Versus.Shared.Categories;

public record GetCategoriesResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; } = null!;
    public string? Description { get; init; }
    public byte[]? Image { get; init; }
}