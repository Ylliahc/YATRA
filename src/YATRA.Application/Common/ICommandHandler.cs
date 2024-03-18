namespace YATRA.Application;

public interface ICommandHandler<TCommand, TResult>
{
    TResult Handle();
}
