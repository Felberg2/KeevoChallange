namespace Taskio.Domain.Entities
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<string> Errors { get; set; } = [];

        public BaseResponse() { }

        public BaseResponse(string message)
        {
            Success = true;
            Message = message;
        }

        public BaseResponse(List<string> errors)
        {
            Success = false;
            Errors = errors;
        }
    }
}
