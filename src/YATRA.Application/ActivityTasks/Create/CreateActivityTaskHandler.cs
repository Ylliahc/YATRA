using YATRA.Application.Common;
using YATRA.Core;

namespace YATRA.Application;

public class CreateActivityTaskHandler: ICommandHandler<ActivityTask, Result<ActivityTask, IError>>
{
    private readonly IActivityTaskRepository _activityTaskRepository;

    public CreateActivityTaskHandler(IActivityTaskRepository activityTaskRepository)
    {
        _activityTaskRepository = activityTaskRepository;
    }

    public Result<ActivityTask, IError> Handle()
    {
        return new ActivityTask();
    }
}
