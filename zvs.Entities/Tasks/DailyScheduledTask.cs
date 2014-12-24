﻿using System;

namespace zvs.DataModel.Tasks
{
    public interface IDailyScheduledTask
    {
        DateTime StartTime { get; set; }
        int RepeatIntervalInDays { get; set; }
    }
}
