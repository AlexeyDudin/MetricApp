using MetricInfrastructure.Storage;
using MetricInfrastructure.Storage.Interfaces;
using MetricInfrastructure.Storage.Repositoryes;
using Splat;

namespace MetricApp.DependencyInjection
{
    public static class ServicesBootstrapper
    {
        public static void RegisterModelCollections(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
        {
            var efContext = resolver.GetService<IEfContext>() as EfContext;
            services.Register<IMetricImageRepository>(() => new MetricImageRepository(efContext));
        }
    }
}
