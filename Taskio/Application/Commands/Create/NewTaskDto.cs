namespace Taskio.Application.Commands.Create
{
    public class NewTaskDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Status { get; set; }
    }
}
