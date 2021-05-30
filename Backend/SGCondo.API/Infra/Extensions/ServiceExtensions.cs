using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SGCondo.Data.DataContext;
using SGCondo.Framework.DataContext;

namespace SGCondo.API.Infra.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterDatabases(this IServiceCollection services)
        {
            #region Database Configuration
            services.AddDbContext<IDbContext, AppDbContext>(o => o.UseLazyLoadingProxies());
            services.AddResponseCaching();
            #endregion Database Configuration

            return services;
        }

        public static IServiceCollection SetupMappingProfile(this IServiceCollection services)
        {
            #region Mapping Profile

            #endregion Mapping Profile
            return services;
        }
    }
}
