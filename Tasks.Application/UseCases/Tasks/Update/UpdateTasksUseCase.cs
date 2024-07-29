using Tasks.Communication.Request;
using Tasks.Communication.Response;

namespace Tasks.Application.UseCases.Tasks.Update;

public class UpdateTasksUseCase
{
    public ResponseInsertTaskJSON Execute(int id, RequestTaskJSON request)
    {

        foreach (var item in ResponseListJSON.TaskInList)
        {
            if (item.Id == id)
            {
                item.Id = request.Id ;
                item.Status = request.Status ;
                item.Name = request.Name ;
                item.Description = request.Description ;
                item.Priority = request.Priority ;
                item.Time = request.Time ;
                item.Status = request.Status ;

                return item;
            }

        }

        return null;
    }
}
