using Tasks.Communication.Enum;

namespace Tasks.Communication.Response;

public class ResponseTaskJSON
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public TasksPriority Priority { get; set; }
    public DateTime Time { get; set; }
    public TasksStatus Status { get; set; }
}
