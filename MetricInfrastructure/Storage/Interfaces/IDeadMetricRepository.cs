namespace MetricInfrastructure.Storage.Interfaces
{
    public interface IDeadMetricRepository
    {
        public IRepository<IDeadMetricRepository> Database { get; }
        void Dispose();
        void Commit();
        Task CommitAsync();
    }
}
