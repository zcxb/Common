using System;

namespace Common.Auditing
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
