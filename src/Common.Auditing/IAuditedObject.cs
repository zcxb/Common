﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Auditing
{
    public interface IAuditedObject<TUserId> : ICreationAuditedObject<TUserId>, IModificationAuditedObject<TUserId>
        where TUserId : struct
    {
    }
}
