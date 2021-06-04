using System.Linq;

namespace SGCondo.Framework.Filter.Extensions
{
    public static class FilterExtension
    {

        public static IQueryable<TEntity> Paginate<TEntity>(this IQueryable<TEntity> query, IPaginated filter)
        {
            if (filter?.SkipPagination == true || filter == null)
                return query;

            return query.Skip(filter?.Offset ?? 0).Take(filter?.Results ?? 0);
        }

    }
}
