using Common.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Ddd.Domain.Entities.Auditing
{
    [Serializable]
    public abstract class CreationAuditedEntity<TUserId> : Entity, ICreationAuditedObject<TUserId>
        where TUserId : struct
    {
        public virtual DateTime CreationTime { get; protected set; }

        public virtual TUserId? CreatorId { get; protected set; }
    }

    [Serializable]
    public abstract class CreationAuditedEntity<TUserId, TKey> : Entity<TKey>, ICreationAuditedObject<TUserId>
        where TUserId : struct
    {
        public virtual DateTime CreationTime { get; protected set; }

        public virtual TUserId? CreatorId { get; protected set; }

        protected CreationAuditedEntity()
        {

        }

        protected CreationAuditedEntity(TKey id)
            : base(id)
        {

        }
    }
}
