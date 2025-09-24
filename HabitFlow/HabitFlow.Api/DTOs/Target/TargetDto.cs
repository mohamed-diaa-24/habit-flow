namespace HabitFlow.Api.DTOs.Target;

public sealed record TargetDto
{
    public required int Value { get; init; }
    public required string Unit { get; init; }
}
