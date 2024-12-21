using MetricModel.Models;

namespace MetricInfrastructure.Storage.Interfaces
{
    public interface IWeddingMetricRepository
    {
        public IRepository<WeddingMetricEntity> Database { get; }
        void Dispose();
        void Commit();
        Task CommitAsync();
    }
}
