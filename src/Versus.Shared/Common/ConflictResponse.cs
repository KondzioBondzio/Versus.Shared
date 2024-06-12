using System.Collections;

namespace Versus.Shared.Common;

public record ConflictResponse
{
    public ConflictResponse(string details)
    {
        Details = details;
    }

    public ConflictResponse(string details, IEnumerable<ConflictDetail> errors)
    {
        Details = details;
        Errors = errors;
    }

    public string Details { get; init; }
    public IEnumerable<ConflictDetail> Errors { get; init; } = [];
}

public record ConflictDetail(string ResourceType, string ResourceIds, string Description)
{
    public static ConflictDetail FromResource<TResourceType, TResourceId>(TResourceId resourceId, string description)
        where TResourceType : class
    {
        return new ConflictDetail(typeof(TResourceType).Name, resourceId!.ToString()!, description);
    }

    public static ConflictDetail FromResource<TResourceType>(IEnumerable resourceIds, string description)
        where TResourceType : class
    {
        return FromResource<TResourceType, string>(string.Join(",", resourceIds), description);
    }
}