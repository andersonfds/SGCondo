using Microsoft.EntityFrameworkCore;
using SGCondo.Data.Repository;
using SGCondo.Domain;
using SGCondo.Framework.DataContext;
using SGCondo.Repository.Infra;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace SGCondo.Repository
{
    public class CondominiumRepository : RepositoryBase<Condominium>, ICondominiumRepository
    {
        public CondominiumRepository(IDbContext context) : base(context) { }
    }
}
