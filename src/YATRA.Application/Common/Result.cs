namespace YATRA.Application.Common;

public sealed class Result<TValue, TError>
    where TError : IError
{
    public TValue? Value { get; init; }
    public TError? Error { get; init; }
    public bool Successed { get; init; }

    private Result(TValue value)
    {
        Value = value;
        Successed = true;
    }

    private Result(TError error)
    {
        Error = error;
        Successed = false;
    }

    public static implicit operator Result<TValue, TError>(TValue value) => new Result<TValue, TError>(value);
    public static implicit operator Result<TValue, TError>(TError error) => new Result<TValue, TError>(error);

    public Result<TValue, TError> Match(Func<TValue, Result<TValue, TError>> success, Func<TError, Result<TValue, TError>> failure)
    {
        if (Successed)
        {
            return success(Value!);
        }
        return failure(Error!);
    }
}