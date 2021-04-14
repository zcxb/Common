using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Auditing
{
    public interface IHasModificationTime
    {
        DateTime? LastModificationTime { get; set; }
    }
}
