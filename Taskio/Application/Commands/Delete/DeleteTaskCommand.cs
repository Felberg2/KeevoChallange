using MediatR;

namespace Taskio.Application.Commands.Delete
{
    public class DeleteTaskCommand(Guid id) : IRequest<DeleteTaskCommandResponse>
    {
        public Guid Id { get; set; } = id;
    }
}
