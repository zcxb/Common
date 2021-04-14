using Rise.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Auditing
{
    public interface IHasDeletionTime : ISoftDelete
    {
        DateTime? DeletionTime { get; set; }
    }
}
