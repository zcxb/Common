using Rise.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Auditing
{
    public abstract class AuditedModelBase : ISoftDelete
    {
        public virtual int Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime InsertedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
