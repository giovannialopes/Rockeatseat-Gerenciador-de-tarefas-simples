using Tasks.Communication.Response;

namespace Tasks.Application.UseCases.Tasks.Delete;

public class GetDeleteTasksUseCase
{
    public ResponseInsertTaskJSON Execute(int id)
    {

        foreach (var item in ResponseListJSON.TaskInList)
        {
            if (item.Id == id)
            {
                ResponseListJSON.TaskInList.Remove(item);
                return item;
            }

        }

        return null;
    }
}
