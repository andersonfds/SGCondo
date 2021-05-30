using Microsoft.EntityFrameworkCore;
using SGCondo.Framework.DataContext;
using System.Threading.Tasks;

namespace SGCondo.Data.Repository
{
    public class RepositoryBase<TEntity> where TEntity : class
    {
        protected readonly IDbContext Context;

        public RepositoryBase(IDbContext context)
        {
            Context = context;
        }

        public async virtual Task<TEntity> GetOne(params object[] id) => await Context.Set<TEntity>().FindAsync(id);

        public DbSet<T> Set<T>() where T : class => Context.Set<T>();

        public void SetAdded(TEntity entity) => Set<TEntity>().Add(entity);

        public void SetChanged(TEntity entity) => Set<TEntity>().Update(entity);

        public void SetDeleted(TEntity entity) => Set<TEntity>().Remove(entity);
    }
}
