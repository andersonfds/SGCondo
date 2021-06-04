using Microsoft.Extensions.DependencyInjection;
using SGCondo.Business;
using SGCondo.Business.Infra;
using SGCondo.Data.Service;
using SGCondo.Framework.Service;
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

        public static IServiceCollection LoadSingleton(this IServiceCollection services)
        {
            #region Singletons
            services.AddScoped<IErrorNotification, ErrorNotification>();
            #endregion Singletons

            return services;
        }
    }
}
