﻿using System.Collections.Generic;

namespace SlackNet;

public class UserGroupPreferences
{
    public IList<string> Channels { get; set; } = new List<string>();
    public IList<string> Groups { get; set; } = new List<string>();
}