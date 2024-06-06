namespace Versus.Shared.Relationships;

public record UnblockFriendshipRequest
{
    public required Guid Id { get; init; }
}