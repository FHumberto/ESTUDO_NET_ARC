using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace CAEFMR.Application.Models;

public class CustomProblemDetails : ProblemDetails
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IDictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
}