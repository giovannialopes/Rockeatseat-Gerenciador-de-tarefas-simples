using Microsoft.AspNetCore.Mvc;
using Tasks.Application.UseCases.Tasks.Insert;
using Tasks.Communication.Request;

namespace Tasks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    public IActionResult Post([FromBody] RequestTaskJSON request)
    {
        var response = new InsertTasksUseCase().Execute(request);
        return Ok(request);
    }

}
