namespace YATRA.Core;

public class ActivityTask
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public ActivityTaskStatus Status { get; set; }
}

public enum ActivityTaskStatus
{
    None,
    Started,
    OnGoing,
    Finished
}
