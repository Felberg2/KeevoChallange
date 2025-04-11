using MediatR;

namespace Taskio.Application.Commands.Update
{
    public class UpdateTaskCommand(UpdateTaskDto updatedTask) : IRequest<UpdateTaskCommandResponse>
    {
        public UpdateTaskDto UpdatedTask { get; private set; } = updatedTask;
    }
}
