using Microsoft.Extensions.DependencyInjection;
using TaskMaster.Application.Contract;
using TaskMaster.Application.Services;
using TaskMaster.Infrastructure.Extension;

namespace TaskMaster.Application.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddRepoService();
            services.AddScoped<ITaskService, TaskService>();
            services.AddScoped<IProjectService, ProjectService>();



            return services;
        }
    }
}
