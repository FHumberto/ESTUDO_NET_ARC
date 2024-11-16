using System.Diagnostics;
using System.Text.Json.Serialization;

namespace CAEFMR.Application.Wrappers;

[DebuggerDisplay("ErrorCode = {ErrorCode}, FieldName = {FieldName}, Description = {Description}")]
public class Error(ErrorCode errorCode = default, string? description = null, string? fieldName = null)
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)] //? quando vir padrão, não exibe
    public ErrorCode ErrorCode { get; set; } = errorCode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] //? quando vir nulo, não exibe
    public string? FieldName { get; set; } = fieldName;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)] //? quando vir nulo, não exibe
    public string? Description { get; set; } = description;
}
