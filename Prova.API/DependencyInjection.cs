using Microsoft.Extensions.DependencyInjection;
using Prova.Interface;
using Prova.Repository;

namespace Prova.API
{
    public class DependencyInjection
    {

        public static void Register(IServiceCollection serviceProvider)
        {
            RepositoryDependence(serviceProvider);
        }

        public static void RepositoryDependence (IServiceCollection serviceProvider)
        {
            serviceProvider.AddScoped<ILocacaoRepository, LocacaoRepository>();

        }
    }
}
