using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Rise.Threading
{
    public interface ICancellationTokenProvider
    {
        CancellationToken Token { get; }
    }
}
