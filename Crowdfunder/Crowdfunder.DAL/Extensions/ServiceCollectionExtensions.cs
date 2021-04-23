using Crowdfunder.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Crowdfunder.DAL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCrowdfunderContext(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection
                .AddDbContext<CrowdfunderContext>(options =>
                {
                    options
                        .UseLazyLoadingProxies()
                        .UseSqlServer(connectionString, builder => builder.MigrationsAssembly("Crowdfunder.DAL"));
                });
        }
    }
}