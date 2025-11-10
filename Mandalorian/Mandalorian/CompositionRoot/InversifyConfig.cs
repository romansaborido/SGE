using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Domain.Interfaces;
using Data.Repositories;
using Domain.UseCases;

namespace CompositionRoot
{
    public static class InversifyConfig
    {
        public static IServiceCollection AddCompositionRoot(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IListadoMisionesRepository, ListadoMisiones>();
            services.AddScoped<IListadoMisionesUseCases, ListadoMisionesUseCase>();

            return services;
        }
    }
}
