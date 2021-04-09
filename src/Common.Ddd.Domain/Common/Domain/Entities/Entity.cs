using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain.Entities
{
    [Serializable]
    public abstract class Entity : IEntity
    {

    }

    [Serializable]
    public abstract class Entity<TKey> : Entity, IEntity<TKey>
    {
        public virtual TKey Id { get; protected set; }

        protected Entity()
        {

        }

        protected Entity(TKey id)
        {
            Id = id;
        }
    }
}
