using Taskio.Domain.Entities;

namespace Taskio.Application.Commands.Delete
{
    public class DeleteTaskCommandResponse : BaseResponse
    {
        public DeleteTaskCommandResponse() : base() { }
        public DeleteTaskCommandResponse(string message) : base(message) { }
        public DeleteTaskCommandResponse(List<string> errors) : base(errors) { }
    }
}
