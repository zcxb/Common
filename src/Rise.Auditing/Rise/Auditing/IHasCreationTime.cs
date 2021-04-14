using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Auditing
{
    public interface IHasCreationTime
    {
        DateTime CreationTime { get; }
    }
}
