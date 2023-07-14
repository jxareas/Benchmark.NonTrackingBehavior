using Microsoft.EntityFrameworkCore;

namespace Benchmark.NonTrackingBehavior.Extensions;

public static class QueryableExtensions
{

    public static List<T> ToListNonTracking<T>(this IQueryable<T> queryable)
              where T : class => queryable.AsNoTracking().ToList();

    public static List<T> ToListNonTrackingWithIdentityResolution<T>(this IQueryable<T> queryable)
        where T : class => queryable.AsNoTrackingWithIdentityResolution().ToList();

}
