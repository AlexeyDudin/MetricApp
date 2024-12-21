using MetricModel.Models;

namespace MetricInfrastructure.Storage.Interfaces
{
    public interface IBornMectricRepository
    {
        public IRepository<BornMetricEntity> Datagase { get; }
        public void Dispose();
        public void Commit();
        public void CommitAsync();
    }
}
