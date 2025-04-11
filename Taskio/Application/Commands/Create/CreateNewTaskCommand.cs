using MediatR;

namespace Taskio.Application.Commands.Create
{
    public class CreateNewTaskCommand(NewTaskDto newTask) : IRequest<CreateNewTaskCommandResponse>
    {
        public NewTaskDto NewTask { get; set; } = newTask;
    }
}
