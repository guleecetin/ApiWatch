using ApiWatch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiWatch.Infrastructure.Persistence
{
    public class ApiWatchDbContext : DbContext
    {
        public ApiWatchDbContext(DbContextOptions<ApiWatchDbContext> options) : base(options)
        {
        }
            public DbSet<ApiMonitor> Monitors => Set<ApiMonitor>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApiWatchDbContext).Assembly);
        }


        }



    }

