using Data.Repositories;
using Domain.Interfaces;
using Domain.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompositionRoot
{
    public static class InversifyConf
    {
        public static IServiceCollection AddCompositionRoot(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IPlantaRepository, PlantaRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();

            services.AddScoped<IPlantaUseCases, PlantaUseCases>();
            services.AddScoped<ICategoriaUseCases, CategoriaUseCases>();

            return services;
        }
    }
}
