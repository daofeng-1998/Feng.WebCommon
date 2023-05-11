using System.Linq.Expressions;
using Feng.WebCommon.Models;
using Microsoft.EntityFrameworkCore;

namespace System.Linq;

public static class QueryableExtensions {
    public static async Task<PageResult<IEnumerable<T>>> PagingAsync<T>(this IQueryable<T> queryable,
        PageQuery pageQuery) {
        var total = await queryable.LongCountAsync();
        var skipCont = pageQuery.PageSize * (pageQuery.PageIndex - 1);

        var data = await queryable
            .Skip(skipCont)
            .Take(pageQuery.PageSize)
            .ToListAsync();

        return new PageResult<IEnumerable<T>>(total, pageQuery.PageSize, pageQuery.PageIndex, data);
    }

    public static IQueryable<T> Where<T>(
        this IQueryable<T> query,
        bool condition,
        Expression<Func<T, bool>> predicate
    ) {
        return condition ? query.Where(predicate) : query;
    }
}