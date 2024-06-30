namespace Versus.Shared.Rooms;

public record GetRoomResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
    public bool PasswordProtected { get; init; }
    public DateTime PlayDate { get; init; }

    public Guid CategoryId { get; init; }
    public byte[]? CategoryImage { get; init; }
    public string CategoryName { get; init; } = null!;

    public Guid OwnerId { get; init; }
    public byte[]? OwnerImage { get; init; }
    public string OwnerName { get; init; } = null!;

    public ICollection<User> Guests { get; init; } = new HashSet<User>();
    public ICollection<Team> Teams { get; init; } = new HashSet<Team>();
    public ICollection<ChatMessage> ChatMessages { get; init; } = new HashSet<ChatMessage>();
}

public record ChatMessage
{
    public Guid Id { get; init; }
    public DateTime Timestamp { get; init; }

    public Guid UserId { get; init; }
    public byte[]? UserImage { get; set; }
    public string UserName { get; init; } = null!;

    public string Content { get; init; } = null!;
}

public record Team
{
    public Guid Id { get; init; }
    public string Name { get; init; } = null!;

    public ICollection<User> Members { get; init; } = new HashSet<User>();
}

public record User
{
    public Guid Id { get; init; }
    public string Name { get; init; } = null!;
    public byte[]? Image { get; set; }
}