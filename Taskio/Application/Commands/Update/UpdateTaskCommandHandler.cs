using MediatR;

namespace Taskio.Application.Commands.Update
{
    public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand, UpdateTaskCommandResponse>
    {
        public async Task<UpdateTaskCommandResponse> Handle(UpdateTaskCommand command, CancellationToken cancellationToken)
        {
            var response = new UpdateTaskCommandResponse();
            return Task.FromResult(response).Result;
        }
    }
}
