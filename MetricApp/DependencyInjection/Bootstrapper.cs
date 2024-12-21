using System.Configuration;
using MetricInfrastructure.Storage;
using MetricInfrastructure.Storage.Interfaces;
using Splat;

namespace MetricApp.DependencyInjection
{
    public static class Bootstrapper
    {
        public static void Register(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
        {
            services.Register<IEfContext>(() => new EfContext("Data Source=Metric.db"));
            ServicesBootstrapper.RegisterModelCollections(services, resolver);
            ViewModelBootstrapper.Register(services, resolver);
        }
    }
}
