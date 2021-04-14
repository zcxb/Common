using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Auditing
{
    public interface IMayHaveCreator<TUserId>
        where TUserId : struct
    {
        TUserId? CreatorId { get; }
    }
}
