namespace Tasks.Communication.Response;

public class ResponseAllTasksJSON
{
    public List<ResponseShortTaskJSON> Tasks { get; set; } = new List<ResponseShortTaskJSON>();
}
