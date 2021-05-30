using Microsoft.Extensions.DependencyInjection;
using SGCondo.Business;
using SGCondo.Business.Infra;
using SGCondo.Repository;
using SGCondo.Repository.Infra;

namespace SGCondo.CrossCutting.IoC
{
    public static class SGCondoBootStrapper
    {

        public static IServiceCollection LoadRepository(this IServiceCollection services)
        {
            #region Repository
            services.AddScoped<ICondominiumRepository, CondominiumRepository>();
            #endregion Repository
            return services;
        }

        public static IServiceCollection LoadBusiness(this IServiceCollection services)
        {
            #region Business Logic
            services.AddScoped<ICondominiumBLL, CondominiumBLL>();
            #endregion Business Logic
            return services;
        }
    }
}
