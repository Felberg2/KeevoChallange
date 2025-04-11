using Taskio.Domain.Entities;

namespace Taskio.Domain.Repositories
{
    public interface ITaskItemRepository
    {
        public Task<TaskItem> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        public Task<List<TaskItem>> GetTasksAsync(CancellationToken cancellationToken);
        public Task AddAsync(TaskItem task, CancellationToken cancellationToken);
        public Task UpdateAsync(TaskItem task, CancellationToken cancellationToken);
        public Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
