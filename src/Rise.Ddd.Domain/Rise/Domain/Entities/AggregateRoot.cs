﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Domain.Entities
{
    [Serializable]
    public abstract class AggregateRoot : Entity, IAggregateRoot
    {

    }

    [Serializable]
    public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot<TKey>
    {
        protected AggregateRoot()
        {

        }

        protected AggregateRoot(TKey id)
            : base(id)
        {

        }
    }
}
