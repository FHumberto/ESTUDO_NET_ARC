using System.Text.Json.Serialization;

namespace CAEFMR.Application.Wrappers;

public class BaseResponse
{
    public bool Success { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] //? quando vir nulo, não exibe
    public List<Error>? Errors { get; set; }

    public static BaseResponse Ok()
        => new() { Success = true };

    public static BaseResponse Failure()
        => new() { Success = false };

    public static BaseResponse Failure(Error error)
        => new() { Success = false, Errors = [error] };

    public static BaseResponse Failure(IEnumerable<Error> errors)
        => new() { Success = false, Errors = errors.ToList() };

    public static implicit operator BaseResponse(Error error)
        => new() { Success = false, Errors = [error] };

    public static implicit operator BaseResponse(List<Error> errors)
        => new() { Success = false, Errors = errors };

    public BaseResponse AddError(Error error)
    {
        Errors ??= [];
        Errors.Add(error);
        Success = false;
        return this;
    }
}

public class BaseResponse<TData> : BaseResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] //? quando vir nulo, não exibe
    public TData? Data { get; set; }

    public static BaseResponse<TData> Ok(TData data)
        => new() { Success = true, Data = data };
    public new static BaseResponse<TData> Failure()
        => new() { Success = false };

    public new static BaseResponse<TData> Failure(Error error)
        => new() { Success = false, Errors = [error] };

    public new static BaseResponse<TData> Failure(IEnumerable<Error> errors)
        => new() { Success = false, Errors = errors.ToList() };

    public static implicit operator BaseResponse<TData>(TData data)
        => new() { Success = true, Data = data };

    public static implicit operator BaseResponse<TData>(Error error)
        => new() { Success = false, Errors = [error] };

    public static implicit operator BaseResponse<TData>(List<Error> errors)
        => new() { Success = false, Errors = errors };
}