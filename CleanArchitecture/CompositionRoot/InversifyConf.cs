using Microsoft.Extensions.DependencyInjection;

using Domain.Interfaces;
using Domain.Entities;
using Domain.UseCases;
using Data.Repositories;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IUseCases;
using Microsoft.Extensions.Configuration;

namespace CompositionRoot
{
    public static class InversifyConfig
    {
        public static IServiceCollection AddCompositionRoute(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IListadoPersonasRepository, ListadoPersonas>();
            services.AddScoped<IGetListadoPersonasUseCase, GetListadoPersonas>();

            return services;
        }
    }
}
