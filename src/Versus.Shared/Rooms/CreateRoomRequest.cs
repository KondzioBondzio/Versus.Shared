namespace Versus.Shared.Rooms;

public record CreateRoomRequest
{
    public required string Name { get; init; }
    public required string Description { get; init; }
    public string? Password { get; init; }
    public required DateTime PlayDate { get; init; }
    
    public required Guid CategoryId { get; init; }
    
    public int TeamCount { get; init; }
    public int TeamPlayerLimit { get; init; }
}