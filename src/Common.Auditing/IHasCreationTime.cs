﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Auditing
{
    public interface IHasCreationTime
    {
        DateTime CreationTime { get; }
    }
}
