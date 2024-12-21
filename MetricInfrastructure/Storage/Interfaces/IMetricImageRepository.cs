using MetricModel.Models;

namespace MetricInfrastructure.Storage.Interfaces
{
    public interface IMetricImageRepository
    {
        public IRepository<MetricImage> Database { get; }
        void Dispose();
        void Commit();
        Task CommitAsync();
    }
}
