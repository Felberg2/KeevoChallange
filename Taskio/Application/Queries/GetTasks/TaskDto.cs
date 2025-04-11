using Taskio.Domain.Entities;
using Taskio.Domain.Enumerables;

namespace Taskio.Application.Queries.GetTasks
{
    public class TaskDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Status Status { get; set; }

        public TaskDto(TaskItem taskItem)
        { 
            Id = taskItem.Id;
            Name = taskItem.Name;
            Description = taskItem.Description;
            Status = taskItem.Status;
        }
    }
}
