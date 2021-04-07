using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Auditing
{
    public interface IHasModificationTime
    {
        DateTime? LastModificationTime { get; set; }
    }
}
