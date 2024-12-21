using MetricModel.Models;

namespace MetricInfrastructure.Storage.Interfaces
{
    public interface ICouseOfDeathRepository
    {
        IRepository<CouseOfDeath> Database { get; }
        void Dispose();
        void Commit();
        Task CommitAsync();
    }
}
