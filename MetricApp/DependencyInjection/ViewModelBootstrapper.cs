using MetricInfrastructure.Storage.Interfaces;
using MetricViewModel;
using Splat;

namespace MetricApp.DependencyInjection
{
    public static class ViewModelBootstrapper
    {
        public static void Register(IMutableDependencyResolver services, IReadonlyDependencyResolver resolver)
        {
            var imageRepos = resolver.GetService<IMetricImageRepository>();

            services.Register<IMainWindowViewModel>(() => new MainWindowViewModel(imageRepos));
        }
    }
}
