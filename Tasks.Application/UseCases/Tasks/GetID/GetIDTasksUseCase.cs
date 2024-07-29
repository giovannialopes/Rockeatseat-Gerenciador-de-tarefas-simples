using Tasks.Communication.Response;

namespace Tasks.Application.UseCases.Tasks.GetID;

public class GetIDTasksUseCase
{
    public ResponseInsertTaskJSON Execute(int id)
    {

        foreach (var item in ResponseListJSON.TaskInList)
        {
            if (item.Id == id)
            {
                return item;
            }
            
        }

        return null;
    }

}