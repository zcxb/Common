using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}
