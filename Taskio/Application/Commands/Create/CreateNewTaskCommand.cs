using MediatR;

namespace Taskio.Application.Commands.Create
{
    public class CreateNewTaskCommand : IRequest<CreateNewTaskCommandResponse>
    {
    }
}
