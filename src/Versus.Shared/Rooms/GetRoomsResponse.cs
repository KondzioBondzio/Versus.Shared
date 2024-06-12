namespace Versus.Shared.Rooms;

public record GetRoomsResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; } = null!;
    public bool PasswordProtected { get; init; }

    public Guid CategoryId { get; init; }
    public byte[]? CategoryImage { get; init; }
    public string CategoryName { get; init; } = null!;

    public Guid OwnerId { get; init; }
    public byte[]? OwnerImage { get; init; }
    public string OwnerName { get; init; } = null!;

    public int OccupiedSlots { get; init; }
    public int TotalSpots { get; init; }
}