using ApiWatch.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiWatch.Infrastructure

{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrWhiteSpace(connectionString)) {

                throw new InvalidOperationException("'DefaultConnection' connection string bulunamadı.");
            }
            services.AddDbContext<ApiWatchDbContext>(options => options.UseNpgsql(connectionString));

            return services;


        }
    } }