using MetricModel.Models;

namespace MetricInfrastructure.Storage.Interfaces
{
    public interface IOccupationRepository
    {
        public IRepository<OccupationEntity> Database { get; }
        void Dispose();
        void Commit();
        Task CommitAsync();
    }
}
