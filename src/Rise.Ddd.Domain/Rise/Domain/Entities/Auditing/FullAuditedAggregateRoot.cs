using Rise.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Domain.Entities.Auditing
{
    [Serializable]
    public abstract class FullAuditedAggregateRoot<TUserId> : AuditedAggregateRoot<TUserId>, IFullAuditedObject<TUserId>
        where TUserId : struct
    {
        public bool IsDeleted { get; set; }

        public TUserId? DeleterId { get; set; }

        public DateTime? DeletionTime { get; set; }
    }

    [Serializable]
    public abstract class FullAuditedAggregateRoot<TUserId, TKey> : AuditedAggregateRoot<TUserId, TKey>, IFullAuditedObject<TUserId>
        where TUserId : struct
    {
        public bool IsDeleted { get; set; }

        public TUserId? DeleterId { get; set; }

        public DateTime? DeletionTime { get; set; }

        protected FullAuditedAggregateRoot()
        {

        }

        protected FullAuditedAggregateRoot(TKey id)
        : base(id)
        {

        }
    }
}
