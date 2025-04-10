using MediatR;

namespace Taskio.Application.Queries.GetTasks
{
    public class GetTasksQueryHandler : IRequestHandler<GetTasksQuery, GetTasksQueryResponse>
    {
        public async Task<GetTasksQueryResponse> Handle(GetTasksQuery query, CancellationToken cancellationToken)
        {
            var response = new GetTasksQueryResponse();
            return Task.FromResult(response).Result;
        }
    }
}
