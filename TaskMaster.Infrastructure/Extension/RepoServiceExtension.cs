using Microsoft.Extensions.DependencyInjection;
using TaskMaster.Infrastructure.Context;
using TaskMaster.Infrastructure.IRepository;
using TaskMaster.Infrastructure.Repository;

namespace TaskMaster.Infrastructure.Extension
{
    public static class RepoServiceExtension
    {
        public static IServiceCollection AddRepoService(this IServiceCollection services)
        {
            services.AddSingleton<AppSettingsReader>();
            services.AddScoped<IDbConfiguration, DbConfiguration>();
            services.AddScoped<ITaskRepository, TaskRepository>();
           return services;
        }
    }
}
