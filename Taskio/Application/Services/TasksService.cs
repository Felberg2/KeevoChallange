using Taskio.Application.Interfaces;
using Taskio.Domain.Entities;
using Taskio.Domain.Repositories;

namespace Taskio.Application.Services
{
    public class TasksService(ITaskItemRepository taskItemRepository) : ITasksService
    {
        private readonly ITaskItemRepository _taskItemRepository = taskItemRepository;

        public async Task<TaskItem> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _taskItemRepository.GetByIdAsync(id, cancellationToken);
        }

        public async Task<List<TaskItem>> GetTasks(CancellationToken cancellationToken)
        {
            return await _taskItemRepository.GetTasksAsync(cancellationToken);
        }

        public async Task CreateNewTask(TaskItem task, CancellationToken cancellationToken)
        {
            await _taskItemRepository.AddAsync(task, cancellationToken);
        }

        public async Task UpdateTaskAsync(TaskItem task, CancellationToken cancellationToken)
        {
            await _taskItemRepository.UpdateAsync(task, cancellationToken);
        }

        public async Task DeleteTaskAsync(Guid id, CancellationToken cancellationToken)
        {
            await _taskItemRepository.DeleteAsync(id, cancellationToken);
        }
    }
}
