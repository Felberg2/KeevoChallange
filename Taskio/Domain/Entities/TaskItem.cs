﻿using Taskio.Domain.Enumerables;

namespace Taskio.Domain.Entities
{
    public class TaskItem : AuditableEntity
    {
        public Guid Id { get; private set; }
        public int UserId { get; private set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Status Status { get; private set; }

        public TaskItem() { }

        public TaskItem(string name, string description, int status)
        {
            Id = Guid.NewGuid();
            UserId = 1;
            Name = name;
            Description = description;
            Status = (Status)status;
            Create();
        }

        public void UpdateTask(string name, string description, int status)
        {
            Name = name;
            Description = description;
            Status = (Status)status;
            Update();
        }
    }
}
