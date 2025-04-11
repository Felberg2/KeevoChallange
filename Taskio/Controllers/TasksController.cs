using MediatR;
using Microsoft.AspNetCore.Mvc;
using Taskio.Application.Commands.Create;
using Taskio.Application.Commands.Delete;
using Taskio.Application.Commands.Update;
using Taskio.Application.Queries.GetTasks;

namespace Taskio.Controllers
{
    [Route("api/tasks")]
    [ApiController]
    public class TasksController(IMediator mediator) : BaseController
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet]
        [ProducesResponseType(typeof(GetTasksQueryResponse),StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetTasks(CancellationToken cancellationToken)
        {
            var query = new GetTasksQuery();
            var response = await _mediator.Send(query, cancellationToken);
            return CustomResponse(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(CreateNewTaskCommandResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> CreateTask([FromBody] NewTaskDto newTask, CancellationToken cancellationToken)
        {
            var command = new CreateNewTaskCommand(newTask);
            var response = await _mediator.Send(command, cancellationToken);
            return CustomResponse(response);
        }

        [HttpPut]
        [ProducesResponseType(typeof(UpdateTaskCommandResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateTask([FromBody] UpdateTaskDto updatedTask, CancellationToken cancellationToken)
        {
            var command = new UpdateTaskCommand(updatedTask);
            var response = await _mediator.Send(command, cancellationToken);
            return CustomResponse(response);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(DeleteTaskCommandResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteTask([FromBody] UpdateTaskDto updateTaskDto, CancellationToken cancellationToken)
        {
            var command = new DeleteTaskCommand(updateTaskDto.Id);
            var response = await _mediator.Send(command, cancellationToken);
            return CustomResponse(response);
        }
    }
}
