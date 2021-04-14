using Rise.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Domain.Entities.Auditing
{
    [Serializable]
    public abstract class AuditedAggregateRoot<TUserId> : CreationAuditedAggregateRoot<TUserId>, IAuditedObject<TUserId>
        where TUserId : struct
    {
        public virtual TUserId? LastModifierId { get; set; }

        public virtual DateTime? LastModificationTime { get; set; }
    }

    [Serializable]
    public abstract class AuditedAggregateRoot<TUserId, TKey> : CreationAuditedAggregateRoot<TUserId, TKey>, IAuditedObject<TUserId>
        where TUserId : struct
    {
        public virtual TUserId? LastModifierId { get; set; }

        public virtual DateTime? LastModificationTime { get; set; }

        protected AuditedAggregateRoot()
        {

        }

        protected AuditedAggregateRoot(TKey id)
            : base(id)
        {

        }
    }
}
