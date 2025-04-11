using Taskio.Domain.Entities;

namespace Taskio.Application.Commands.Create
{
    public class CreateNewTaskCommandResponse : BaseResponse
    {
        public CreateNewTaskCommandResponse() : base() { }

        public CreateNewTaskCommandResponse(string message) : base(message) { }

        public CreateNewTaskCommandResponse(List<string> errors) : base(errors) { }
    }
}
