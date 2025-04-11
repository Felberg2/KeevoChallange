using Taskio.Application.Services;
using Taskio.Domain.Repositories;
using Taskio.Infra.Repositories;

namespace Taskio.Application.DependencyInjection
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationServiceRegistration).Assembly));
            services.AddScoped<ITaskItemRepository, TaskItemRepository>();
            services.AddScoped<ITasksService, TasksService>();

            return services;
        }
    }
}
