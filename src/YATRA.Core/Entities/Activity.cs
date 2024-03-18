namespace YATRA.Core;

public class Activity
{
    public string Tag { get; set; }
    public string Name { get; set; }
    public string Descriptions { get; set; }
    public List<Activity> Mothers {get;set;}
    public List<Activity> Children { get; set; }
}
