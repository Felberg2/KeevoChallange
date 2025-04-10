using MediatR;

namespace Taskio.Application.Queries.GetTasks
{
    public class GetTasksQuery : IRequest<GetTasksQueryResponse>
    {
    }
}
