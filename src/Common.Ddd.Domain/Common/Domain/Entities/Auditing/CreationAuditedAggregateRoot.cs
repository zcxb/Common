using Common.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain.Entities.Auditing
{
    [Serializable]
    public abstract class CreationAuditedAggregateRoot<TUserId> : AggregateRoot, ICreationAuditedObject<TUserId>
        where TUserId : struct
    {
        public DateTime CreationTime { get; protected set; }

        public TUserId? CreatorId { get; protected set; }
    }

    public abstract class CreationAuditedAggregateRoot<TUserId, TKey> : AggregateRoot<TKey>, ICreationAuditedObject<TUserId>
        where TUserId : struct
    {
        public DateTime CreationTime { get; protected set; }

        public TUserId? CreatorId { get; protected set; }

        protected CreationAuditedAggregateRoot()
        {

        }

        protected CreationAuditedAggregateRoot(TKey id)
            : base(id)
        {

        }
    }
}
