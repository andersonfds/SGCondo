using SGCondo.Domain;
using SGCondo.Framework.Repository;
using SGCondo.Repository.Infra.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGCondo.Repository.Infra
{
    public interface ICondominiumRepository : IRepository<Condominium>
    {
        Task<IEnumerable<Condominium>> GetAll(CondominiumQuerySpec querySpec = null);
    }
}
