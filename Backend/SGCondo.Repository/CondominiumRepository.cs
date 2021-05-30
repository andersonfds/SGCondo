using SGCondo.Data.Repository;
using SGCondo.Domain;
using SGCondo.Framework.DataContext;
using SGCondo.Repository.Infra;

namespace SGCondo.Repository
{
    public class CondominiumRepository : RepositoryBase<Condominium>, ICondominiumRepository
    {
        public CondominiumRepository(IDbContext context) : base(context) { }
    }
}
