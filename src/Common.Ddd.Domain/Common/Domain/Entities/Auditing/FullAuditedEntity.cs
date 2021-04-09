using Common.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain.Entities.Auditing
{
    [Serializable]
    public abstract class FullAuditedEntity<TUserId> : AuditedEntity<TUserId>, IFullAuditedObject<TUserId>
        where TUserId : struct
    {
        public virtual bool IsDeleted { get; set; }

        public virtual TUserId? DeleterId { get; set; }

        public virtual DateTime? DeletionTime { get; set; }
    }

    [Serializable]
    public abstract class FullAuditedEntity<TUserId, TKey> : AuditedEntity<TUserId, TKey>, IFullAuditedObject<TUserId>
        where TUserId : struct
    {
        public virtual bool IsDeleted { get; set; }

        public virtual TUserId? DeleterId { get; set; }

        public virtual DateTime? DeletionTime { get; set; }

        protected FullAuditedEntity()
        {

        }

        protected FullAuditedEntity(TKey id)
            : base(id)
        {

        }
    }
}
