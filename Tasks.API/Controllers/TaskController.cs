using Microsoft.AspNetCore.Mvc;
using Tasks.Application.UseCases.Tasks.GetID;
using Tasks.Application.UseCases.Tasks.Insert;
using Tasks.Communication.Request;
using Tasks.Communication.Response;

namespace Tasks.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseInsertTaskJSON), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJSON), StatusCodes.Status400BadRequest)]
    public IActionResult Post([FromBody] RequestTaskJSON request)
    {
        var response = new InsertTasksUseCase().Execute(request);
        ResponseListJSON.TaskInList.Add(response);

        return Created("",response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseInsertTaskJSON), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJSON), StatusCodes.Status400BadRequest)]
    public IActionResult GetAll()
    {
        var response = ResponseListJSON.TaskInList;
        if (ResponseListJSON.TaskInList.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseInsertTaskJSON), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJSON), StatusCodes.Status400BadRequest)]
    public IActionResult GetID(int id)
    {
        var response = new GetIDTasksUseCase().Execute(id);

        return Ok(response);
    }

}
