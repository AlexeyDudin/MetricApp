using MetricModel.Models;

namespace MetricInfrastructure.Storage.Interfaces
{
    public interface IResidencePlaceRepository
    {
        public IRepository<ResidencePlaceEntity> Database { get; }
        void Dispose();
        void Commit();
        Task CommitAsync();
    }
}
