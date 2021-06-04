using SGCondo.Business.Infra;
using SGCondo.Domain;
using SGCondo.Framework.Business;
using SGCondo.Framework.Service;
using SGCondo.Repository.Infra;
using SGCondo.Repository.Infra.Filters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SGCondo.Business
{
    public class CondominiumBLL : BusinessBase, ICondominiumBLL
    {
        protected readonly ICondominiumRepository CondominiumRepository;
        protected readonly IErrorNotification Error;

        public CondominiumBLL(ICondominiumRepository condominiumRepository, IErrorNotification error)
        {
            CondominiumRepository = condominiumRepository;
            Error = error;
        }

        public async Task<IEnumerable<Condominium>> GetAll(CondominiumQuerySpec querySpec)
        {
            return await CondominiumRepository.GetAll(querySpec);
        }

        public Task<Condominium> GetOne(Guid id)
        {
            return CondominiumRepository.GetOne(id);
        }
    }
}
