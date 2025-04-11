using Microsoft.EntityFrameworkCore;
using Taskio.Data;
using Taskio.Domain.Entities;
using Taskio.Domain.Repositories;

namespace Taskio.Infra.Repositories
{
    public class TaskItemRepository(TaskioDbContext dbContext) : ITaskItemRepository
    {
        private readonly TaskioDbContext _dbContext = dbContext;

        public async Task<List<TaskItem>> GetTasksAsync(CancellationToken cancellationToken)
        {
            return await _dbContext
                .Tasks
                .Where(t => !t.IsDeleted)
                .ToListAsync(cancellationToken);
        }

        public async Task AddAsync(TaskItem task, CancellationToken cancellationToken)
        {
            await _dbContext.Tasks.AddAsync(task, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(TaskItem task, CancellationToken cancellationToken)
        {
            _dbContext.Tasks.Update(task);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var task = await _dbContext.Tasks.FindAsync(id, cancellationToken);
            if (task != null)
            {
                _dbContext.Tasks.Remove(task);
                await _dbContext.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
