using MediatR;
using Taskio.Application.Interfaces;

namespace Taskio.Application.Commands.Delete
{
    public class DeleteTaskCommandHandler(ITasksService tasksService) : IRequestHandler<DeleteTaskCommand, DeleteTaskCommandResponse>
    {
        private readonly ITasksService _tasksService = tasksService;

        public async Task<DeleteTaskCommandResponse> Handle(DeleteTaskCommand command, CancellationToken cancellationToken)
        {
            try
            {
                await _tasksService.DeleteTaskAsync(command.Id, cancellationToken);
                return new DeleteTaskCommandResponse("Task deleted successfuly");
            }
            catch (Exception ex)
            {
                return new DeleteTaskCommandResponse([ex.Message]);
            }
        }
    }
}
