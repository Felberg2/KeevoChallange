using MediatR;
using Taskio.Application.Services;
using Taskio.Domain.Entities;

namespace Taskio.Application.Commands.Create
{
    public class CreateNewTaskCommandHandler(ITasksService tasksService) : IRequestHandler<CreateNewTaskCommand, CreateNewTaskCommandResponse>
    {
        private readonly ITasksService _tasksService = tasksService;

        public async Task<CreateNewTaskCommandResponse> Handle(CreateNewTaskCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var newTask = new TaskItem(
                    command.NewTask.Name,
                    command.NewTask.Description,
                    command.NewTask.Status
                );

                await _tasksService.CreateNewTask(newTask, cancellationToken);
                return new CreateNewTaskCommandResponse("Task successfuly created.");
            }
            catch ( Exception ex )
            {
                return new CreateNewTaskCommandResponse([ex.Message]);
            }         
        }
    }
}
