using Common.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Ddd.Domain.Entities.Auditing
{
    [Serializable]
    public abstract class AuditedEntity<TUserId> : CreationAuditedEntity<TUserId>, IAuditedObject<TUserId>
        where TUserId : struct
    {
        public virtual TUserId? LastModifierId { get; set; }

        public virtual DateTime? LastModificationTime { get; set; }
    }

    [Serializable]
    public abstract class AuditedEntity<TUserId, TKey> : CreationAuditedEntity<TUserId, TKey>, IAuditedObject<TUserId>
        where TUserId : struct
    {
        public virtual TUserId? LastModifierId { get; set; }

        public virtual DateTime? LastModificationTime { get; set; }

        protected AuditedEntity()
        {

        }

        protected AuditedEntity(TKey id)
            : base(id)
        {

        }
    }
}
