using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Ddd.Domain.Entities
{
    public interface IAggregateRoot : IEntity
    {
    }

    public interface IAggregateRoot<TKey> : IEntity<TKey>, IAggregateRoot
    {

    }
}
