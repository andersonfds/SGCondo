using SGCondo.Business.Infra;
using SGCondo.Domain;
using SGCondo.Framework.Business;
using SGCondo.Repository.Infra;
using System;
using System.Threading.Tasks;

namespace SGCondo.Business
{
    public class CondominiumBLL : BusinessBase, ICondominiumBLL
    {
        protected readonly ICondominiumRepository CondominiumRepository;

        public CondominiumBLL(ICondominiumRepository condominiumRepository)
        {
            CondominiumRepository = condominiumRepository;
        }

        public Task<Condominium> GetOne(Guid id)
        {
            return CondominiumRepository.GetOne(id);
        }
    }
}
