﻿using System;

namespace AnyStatus.API
{
    public interface ISchedulable
    {
        Guid Id { get; }

        string Name { get; }

        int Interval { get; }
    }
}
