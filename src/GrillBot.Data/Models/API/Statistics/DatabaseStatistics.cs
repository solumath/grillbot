﻿using System.Collections.Generic;

namespace GrillBot.Data.Models.API.Statistics;

public class DatabaseStatistics
{
    public Dictionary<string, int> Database { get; set; }
    public Dictionary<string, int> Cache { get; set; }
}
