using Microsoft.EntityFrameworkCore;
using System;
using Taskio.Domain.Entities;

namespace Taskio.Data
{
    public class TaskioDbContext(DbContextOptions<TaskioDbContext> options) : DbContext(options)
    {
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
