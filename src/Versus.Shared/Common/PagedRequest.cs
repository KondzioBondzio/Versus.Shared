namespace Versus.Shared.Common;

public record PagedRequest
{
    public int? PageNumber { get; init; }
    public int? PageSize { get; init; }

    // OrderBy => default Id
    // OrderDirection? => default Asc
}