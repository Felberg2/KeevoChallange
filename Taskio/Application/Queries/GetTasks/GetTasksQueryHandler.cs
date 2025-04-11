using MediatR;
using Taskio.Application.Services;

namespace Taskio.Application.Queries.GetTasks
{
    public class GetTasksQueryHandler(ITasksService tasksService) : IRequestHandler<GetTasksQuery, GetTasksQueryResponse>
    {
        private readonly ITasksService _tasksService = tasksService;
        public async Task<GetTasksQueryResponse> Handle(GetTasksQuery query, CancellationToken cancellationToken)
        {
            try
            {
                var tasks = await _tasksService.GetTasks(cancellationToken);
                return new GetTasksQueryResponse(tasks, "Tasks retrieved successfuly");
            }
            catch (Exception ex)
            {
                return new GetTasksQueryResponse([ex.Message]);
            }
        }
    }
}
