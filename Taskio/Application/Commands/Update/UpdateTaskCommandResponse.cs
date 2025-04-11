using Taskio.Domain.Entities;

namespace Taskio.Application.Commands.Update
{
    public class UpdateTaskCommandResponse : BaseResponse
    {
        public UpdateTaskCommandResponse() : base() { }
        public UpdateTaskCommandResponse(string message) : base(message) { }
        public UpdateTaskCommandResponse(List<string> errors) : base(errors) { }
    }
}
