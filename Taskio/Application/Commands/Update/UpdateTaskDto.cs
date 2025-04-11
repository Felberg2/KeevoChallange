using Taskio.Domain.Enumerables;

namespace Taskio.Application.Commands.Update
{
    public class UpdateTaskDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Status { get; set; }
    }
}
