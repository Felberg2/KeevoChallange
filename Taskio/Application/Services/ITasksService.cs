using Taskio.Domain.Entities;

namespace Taskio.Application.Services
{
    public interface ITasksService
    {
        public Task CreateNewTask(TaskItem task);
    }
}
