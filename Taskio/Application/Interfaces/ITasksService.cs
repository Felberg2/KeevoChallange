using Taskio.Domain.Entities;

namespace Taskio.Application.Interfaces
{
    public interface ITasksService
    {
        public Task<TaskItem> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        public Task<List<TaskItem>> GetTasks(CancellationToken cancellationToken);
        public Task CreateNewTask(TaskItem task, CancellationToken cancellationToken);
        public Task UpdateTaskAsync(TaskItem taskToBeUpdated, CancellationToken cancellationToken);
        public Task DeleteTaskAsync(Guid id, CancellationToken cancellationToken);
    }
}
