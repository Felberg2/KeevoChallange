using MediatR;

namespace Taskio.Application.Commands.Delete
{
    public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand, DeleteTaskCommandResponse>
    {
        public async Task<DeleteTaskCommandResponse> Handle(DeleteTaskCommand command, CancellationToken cancellationToken)
        {
            var response = new DeleteTaskCommandResponse();
            return Task.FromResult(response).Result;
        }
    }
}
