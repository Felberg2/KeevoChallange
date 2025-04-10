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
        public async Task<IActionResult> GetTasks()
        {
            var query = new GetTasksQuery();
            var response = await _mediator.Send(query);
            return CustomResponse(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(CreateNewTaskCommandResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult CreateTask()
        {
            var response = new CreateNewTaskCommandResponse();
            return CustomResponse(response);
        }

        [HttpPut]
        [ProducesResponseType(typeof(UpdateTaskCommandResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateTask(Task task)
        {
            var response = new UpdateTaskCommandResponse();
            return CustomResponse(response);
        }

        [HttpDelete]
        [ProducesResponseType(typeof(DeleteTaskCommandResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteTask()
        {
            var response = new DeleteTaskCommandResponse();
            return CustomResponse(response);
        }
    }
}
