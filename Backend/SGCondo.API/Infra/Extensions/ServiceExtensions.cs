using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SGCondo.API.Infra.Exceptions;
using SGCondo.API.Infra.Mapping;
using SGCondo.API.UoW;
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

        public static IServiceCollection RegisterUoWs(this IServiceCollection services)
        {
            services.AddScoped<CondominiumUoW>();
            return services;
        }

        public static IServiceCollection SetupMappingProfile(this IServiceCollection services)
        {
            #region Mapping Profile
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainViewModelMappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            #endregion Mapping Profile

            return services;
        }

        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
            return app;
        }
    }
}
