using MediatR;

namespace Taskio.Application.Commands.Create
{
    public class CreateNewTaskCommandHandler : IRequestHandler<CreateNewTaskCommand, CreateNewTaskCommandResponse>
    {
        public async Task<CreateNewTaskCommandResponse> Handle(CreateNewTaskCommand command, CancellationToken cancellationToken)
        {
            var response = new CreateNewTaskCommandResponse();
            return Task.FromResult(response).Result;
        }
    }
}
