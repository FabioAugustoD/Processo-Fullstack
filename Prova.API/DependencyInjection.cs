using Microsoft.Extensions.DependencyInjection;

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

        }
    }
}
