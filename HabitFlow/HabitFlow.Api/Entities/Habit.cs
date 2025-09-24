﻿using HabitFlow.Api.Enums;

namespace HabitFlow.Api.Entities;

public sealed class Habit
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public HapitType Type { get; set; }
    public Frequency Frequency { get; set; }
    public Target Target { get; set; }
    public HabitStatus Status { get; set; }
    public bool IsArchived { get; set; }
    public DateOnly? EndDate { get; set; }
    public Milestone? MileStone { get; set; }
    public DateTime CreatedAtUtc { get; set; }
    public DateTime? UpdatedAtUtc { get; set; }
    public DateTime? LastCompletedAtUtc { get; set; }
}

