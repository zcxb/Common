using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Auditing
{
    public interface ICreationAuditedObject<TUserId> : IHasCreationTime, IMayHaveCreator<TUserId>
        where TUserId : struct
    {
    }
}
