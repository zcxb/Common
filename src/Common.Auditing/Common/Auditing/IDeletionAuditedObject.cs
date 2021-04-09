using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Auditing
{
    public interface IDeletionAuditedObject<TUserId> : IHasDeletionTime
        where TUserId : struct
    {
        TUserId? DeleterId { get; set; }
    }
}
