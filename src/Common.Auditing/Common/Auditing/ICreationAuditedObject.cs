using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Auditing
{
    public interface ICreationAuditedObject<TUserId> : IHasCreationTime, IMayHaveCreator<TUserId>
        where TUserId : struct
    {
    }
}
