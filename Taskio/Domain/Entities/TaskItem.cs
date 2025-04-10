using Taskio.Domain.Enumerables;

namespace Taskio.Domain.Entities
{
    public class TaskItem
    {
        public Guid Id { get; private set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Status Status { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime UpdatedDate { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime DeletedDate { get; private set; }

        public TaskItem() { }

        public TaskItem(string name, string description, int status)
        {
            Id = new Guid();
            Name = name;
            Description = description;
            Status = (Status)status;
            CreatedDate = DateTime.Now;
        }

        public void UpdateStatus(int status)
        {
            Status = (Status)status;
            UpdatedDate = DateTime.Now;
        }

        public void Delete()
        {
            DeletedDate = DateTime.Now;
            IsDeleted = true;
        }
    }
}
