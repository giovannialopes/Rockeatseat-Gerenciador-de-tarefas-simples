using Tasks.Communication.Request;

namespace Tasks.Communication.Response;

public static class ResponseListJSON
{
    public static List<ResponseInsertTaskJSON> TaskInList { get; set; } = new List<ResponseInsertTaskJSON>();
}
