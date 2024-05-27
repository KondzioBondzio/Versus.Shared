﻿namespace Versus.Shared.Common;

public class PagedResponse<T>(int pageIndex, int pageSize, long count, IEnumerable<T> data) where T : class
{
    public int PageIndex { get; } = pageIndex;
    public int PageSize { get; } = pageSize;
    public long Count { get; } = count;
    public IEnumerable<T> Data { get; } = data;
}