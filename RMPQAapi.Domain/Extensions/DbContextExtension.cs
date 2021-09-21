using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RMPQAapi.Data.Context;
using Microsoft.EntityFrameworkCore;


namespace RMPQAapi.Domain.Extensions
{
    public static class DbContextExtension
    {
        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("CarConnection");

            services.AddDbContext<RMPQAapiContext>(options =>
                  options.UseSqlServer(connectionString, x => x.MigrationsAssembly("RMPQAapi.Data")));
        }
    }
}
