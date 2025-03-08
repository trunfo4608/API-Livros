using LivrosAPP.Service.Interfaces;
using LivrosAPP.Service.Repositories;

namespace LivrosAPP.Service.Extensions
{
    public static class DependencyInjectionExtension
    {

        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IAutorRepository, AutorRepository>();
            services.AddTransient<ILivroRepository, LivroRepository>();

            return services;

        }
    }
}
