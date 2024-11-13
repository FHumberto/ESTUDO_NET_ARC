namespace CAEFMR.Infrastructure.Models;

public class MemoryCheckOptions
{
    public required string Memorystatus { get; set; }
    public long Threshold { get; set; } = 1024L * 1024L * 1024L;
}