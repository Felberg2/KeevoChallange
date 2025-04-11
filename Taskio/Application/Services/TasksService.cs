using Taskio.Domain.Entities;
using Taskio.Domain.Repositories;

namespace Taskio.Application.Services
{
    public class TasksService(ITaskItemRepository taskItemRepository) : ITasksService
    {
        private readonly ITaskItemRepository _taskItemRepository = taskItemRepository;

        public async Task<List<TaskItem>> GetTasks(CancellationToken cancellationToken)
        {
            return await _taskItemRepository.GetTasksAsync(cancellationToken);
        }

        public async Task CreateNewTask(TaskItem task, CancellationToken cancellationToken)
        {
            await _taskItemRepository.AddAsync(task, cancellationToken);
        }
    }
}
