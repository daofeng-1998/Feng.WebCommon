namespace Feng.WebCommon.Models;

public class PageResult<T> {
    public long Total { get; init; }
    public int PageSize { get; init; }
    public int Current { get; init; }
    public T Data { get; init; }
    
    public PageResult(long total, int pageSize, int current, T data) {
        Total = total;
        PageSize = pageSize;
        Current = current;
        Data = data;
    }
}