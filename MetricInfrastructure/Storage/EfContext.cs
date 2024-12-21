using MetricInfrastructure.Storage.Configurations;
using MetricInfrastructure.Storage.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MetricInfrastructure.Storage
{
    public class EfContext : DbContext, IEfContext
    {
        private readonly string _connectionString;
        public EfContext(string connectionString)
        {
            _connectionString = connectionString;
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
