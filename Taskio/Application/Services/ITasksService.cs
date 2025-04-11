using Taskio.Domain.Entities;

namespace Taskio.Application.Services
{
    public interface ITasksService
    {
        public Task<List<TaskItem>> GetTasks(CancellationToken cancellationToken);
        public Task CreateNewTask(TaskItem task, CancellationToken cancellationToken);
    }
}
