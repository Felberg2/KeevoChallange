using MediatR;
using Taskio.Application.Interfaces;

namespace Taskio.Application.Commands.Update
{
    public class UpdateTaskCommandHandler(ITasksService tasksService) : IRequestHandler<UpdateTaskCommand, UpdateTaskCommandResponse>
    {
        private readonly ITasksService _tasksService = tasksService;

        public async Task<UpdateTaskCommandResponse> Handle(UpdateTaskCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var taskToBeUpdated = await _tasksService.GetByIdAsync(command.UpdatedTask.Id, cancellationToken);
                taskToBeUpdated.UpdateTask
                (
                    command.UpdatedTask.Name,
                    command.UpdatedTask.Description,
                    command.UpdatedTask.Status
                );
                await _tasksService.UpdateTaskAsync(taskToBeUpdated, cancellationToken);
                return new UpdateTaskCommandResponse("Task updated successfuly");
            }
            catch (Exception ex)
            {
                return new UpdateTaskCommandResponse([ex.Message]);
            }
            
        }
    }
}
