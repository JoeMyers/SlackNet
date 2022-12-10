﻿using System;
using Newtonsoft.Json;

namespace SlackNet.WebApi;

public class SnoozeResponse
{
    public bool SnoozeEnabled { get; set; }
    public int SnoozeEndTime { get; set; }
    [JsonIgnore]
    public DateTime? SnoozeEnd => SnoozeEndTime.ToDateTime();
    public int SnoozeRemaining { get; set; }
    public TimeSpan SnoozeRemainingTimeSpan => TimeSpan.FromSeconds(SnoozeRemaining);
}