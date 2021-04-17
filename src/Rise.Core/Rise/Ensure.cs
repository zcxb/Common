using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Rise
{
    [DebuggerStepThrough]
    public static class Ensure
    {
        public static T NotNull<T>(T value, string parameterName, string message = null)
        {
            return value ?? throw new ArgumentNullException(parameterName, message);
        }
    }
}
