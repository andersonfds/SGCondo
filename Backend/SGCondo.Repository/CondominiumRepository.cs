using Microsoft.EntityFrameworkCore;
using SGCondo.Data.Repository;
using SGCondo.Domain;
using SGCondo.Framework.DataContext;
using SGCondo.Framework.Filter.Extensions;
using SGCondo.Repository.Infra;
using SGCondo.Repository.Infra.Filters;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCondo.Repository
{
    public class CondominiumRepository : RepositoryBase<Condominium>, ICondominiumRepository
    {
        public CondominiumRepository(IDbContext context) : base(context) { }

        public async Task<IEnumerable<Condominium>> GetAll(CondominiumQuerySpec querySpec = null)
        {
            string name = querySpec?.Name ?? string.Empty;
            var query = from condo in Set<Condominium>()
                        where
                            EF.Functions.Like(condo.Name, $"%{name}%")
                        select condo;

            return await query.Paginate(querySpec).ToListAsync();
        }
    }
}
