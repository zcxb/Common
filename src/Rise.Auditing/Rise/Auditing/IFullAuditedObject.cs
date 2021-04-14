using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Auditing
{
    public interface IFullAuditedObject<TUserId> : IAuditedObject<TUserId>, IDeletionAuditedObject<TUserId>
        where TUserId : struct
    {
    }
}
