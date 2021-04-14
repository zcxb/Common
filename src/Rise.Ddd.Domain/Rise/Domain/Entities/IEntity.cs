using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Domain.Entities
{
    public interface IEntity
    {
    }

    public interface IEntity<TKey> : IEntity
    {
        TKey Id { get; }
    }
}
