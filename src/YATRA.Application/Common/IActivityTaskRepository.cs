using YATRA.Core;

namespace YATRA.Application;

public interface IActivityTaskRepository
{
    Task<ActivityTask> Add(ActivityTask activityTask);
}
