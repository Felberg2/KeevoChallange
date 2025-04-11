using Taskio.Domain.Entities;

namespace Taskio.Application.Queries.GetTasks
{
    public class GetTasksQueryResponse : BaseResponse
    {
        public List<TaskDto> ?Tasks { get; set; }

        public GetTasksQueryResponse() : base() { }

        public GetTasksQueryResponse(List<TaskItem> tasks, string message) : base(message)
        { 
            Tasks = ToTaskDto(tasks);
        }

        public GetTasksQueryResponse(List<string> errors) : base(errors) { }


        private static List<TaskDto>? ToTaskDto(List<TaskItem> tasks)
        {
            var taskDtos = new List<TaskDto>(); 
            foreach (var task in tasks)
            {
                taskDtos.Add(new TaskDto(task));
            }
            return taskDtos;
        }
    }
}
