using MetricModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetricInfrastructure.Storage.Configurations
{
    public class BornMetricConfiguration : IEntityTypeConfiguration<BornMetricEntity>
    {
        public void Configure(EntityTypeBuilder<BornMetricEntity> builder)
        {
            builder.ToTable("BornMetricEntitys");
            builder.HasKey(b => b.Id);
        }
    }
}
