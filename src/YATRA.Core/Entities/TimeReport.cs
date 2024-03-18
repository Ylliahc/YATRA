namespace YATRA.Core;

public class TimeReport
{
    public TimeReportStatus Status {get;set;}
    public DateTime Start {get;set;}
    public DateTime End {get;set;}
}

public enum TimeReportStatus
{
    None,
    Started,
    OnGoing,
    Ended
}