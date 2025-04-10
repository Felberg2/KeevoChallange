using MediatR;

namespace Taskio.Application.Commands.Delete
{
    public class DeleteTaskCommand : IRequest<DeleteTaskCommandResponse>
    {
    }
}
