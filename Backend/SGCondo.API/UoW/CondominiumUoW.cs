using SGCondo.Business.Infra;
using SGCondo.Framework.DataContext;
using SGCondo.Framework.UoW;

namespace SGCondo.API.UoW
{
    public class CondominiumUoW : BaseUoW
    {
        public readonly ICondominiumBLL CondominiumBLL;

        public CondominiumUoW(IDbContext context, ICondominiumBLL condominiumBLL) : base(context)
        {
            CondominiumBLL = condominiumBLL;
        }
    }
}
