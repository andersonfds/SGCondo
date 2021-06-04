using SGCondo.Domain;
using SGCondo.Repository.Infra.Filters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGCondo.Business.Infra
{
    public interface ICondominiumBLL
    {
        Task<Condominium> GetOne(Guid id);

        Task<IEnumerable<Condominium>> GetAll(CondominiumQuerySpec querySpec);
    }
}
