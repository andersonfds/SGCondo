using System.Threading.Tasks;

namespace SGCondo.Framework.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetOne(params object[] id);

        void SetAdded(TEntity entity);

        void SetChanged(TEntity entity);

        void SetDeleted(TEntity entity);
    }
}
