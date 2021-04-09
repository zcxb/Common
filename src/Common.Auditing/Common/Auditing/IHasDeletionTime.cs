using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Auditing
{
    public interface IHasDeletionTime : ISoftDelete
    {
        DateTime? DeletionTime { get; set; }
    }
}
