using Microsoft.Extensions.DependencyInjection;

namespace SGCondo.CrossCutting.IoC
{
    public static class SGCondoFactory
    {
        public static IServiceCollection Load(this IServiceCollection services)
        {
            services.LoadRepository();
            services.LoadBusiness();
            services.LoadSingleton();
            return services;
        }
    }
}
