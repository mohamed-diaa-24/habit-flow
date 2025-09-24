﻿using HabitFlow.Api.Enums;

namespace HabitFlow.Api.DTOs.Frequency;

public sealed record FrequencyDto
{
    public required FrequencyType Type { get; init; }
    public required int TimesPerPeriod { get; init; }
}
