using System.Collections.ObjectModel;
using MetricInfrastructure.Storage.Interfaces;

namespace MetricViewModel
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IMetricImageRepository _metricImageRepository;

        public MainWindowViewModel(IMetricImageRepository metricImageRepository)
        {
            _metricImageRepository = metricImageRepository;
        }
    }
}
