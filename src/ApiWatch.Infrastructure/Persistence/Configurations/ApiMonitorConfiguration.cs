using ApiWatch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiWatch.Infrastructure.Persistence.Configurations
{
    public class ApiMonitorConfiguration:IEntityTypeConfiguration<ApiMonitor>
    {
        public void Configure(EntityTypeBuilder<ApiMonitor> builder)
        {
            builder.ToTable("Monitors");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Url)
                .IsRequired()
                .HasMaxLength(2048);

            builder.HasIndex(x => new { x.Enabled, x.NextRunAt });
            builder.HasIndex(x => x.OrganizationId);

        }
    }
}
