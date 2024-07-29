using Tasks.Communication.Request;
using Tasks.Communication.Response;

namespace Tasks.Application.UseCases.Tasks.Insert;

public class InsertTasksUseCase
{
    public ResponseInsertTaskJSON Execute(RequestTaskJSON request)
    {
        return new ResponseInsertTaskJSON
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Status = request.Status,
            Time = request.Time,
        };
    }
}
