﻿namespace Versus.Shared.Categories;

public record UpdateCategoryRequest
{
    public required string Name { get; init; }
    public string? Description { get; init; }
    public byte[]? Image { get; init; }
}