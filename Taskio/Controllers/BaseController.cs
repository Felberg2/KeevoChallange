using Microsoft.AspNetCore.Mvc;
using Taskio.Domain.Entities;

namespace Taskio.Controllers
{
    public class BaseController : ControllerBase
    {
        protected ActionResult CustomResponse(BaseResponse response)
        {
            if (response == null) return NotFound();
            if (response.Success) return Ok(response);
            return BadRequest(response);
        }
    }
}
