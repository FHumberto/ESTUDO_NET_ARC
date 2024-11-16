using System.Text.Json.Serialization;

namespace CAEFMR.Application.Wrappers;

public record Error(ErrorCode ErrorCode = default, string? Description = null, string? FieldName = null)
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] //? quando vir padrão, não exibe
    public ErrorCode ErrorCode { get; init; } = ErrorCode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] //? quando vir nulo, não exibe
    public string? FieldName { get; init; } = FieldName;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] //? quando vir nulo, não exibe
    public string? Description { get; init; } = Description;
}
