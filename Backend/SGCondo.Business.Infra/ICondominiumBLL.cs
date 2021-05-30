using SGCondo.Domain;
using System;
using System.Threading.Tasks;

namespace SGCondo.Business.Infra
{
    public interface ICondominiumBLL
    {
        Task<Condominium> GetOne(Guid id);
    }
}
