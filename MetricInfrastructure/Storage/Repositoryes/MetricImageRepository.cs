using MetricInfrastructure.Storage.Interfaces;
using MetricModel.Models;

namespace MetricInfrastructure.Storage.Repositoryes
{
    public class MetricImageRepository : IMetricImageRepository
    {
        public IRepository<MetricImage> Database { get; private set; }
        private readonly EfContext _context;

        public MetricImageRepository(EfContext efContext)
        {
            _context = efContext;
            Database = new Repository<MetricImage>(efContext);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Task CommitAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
