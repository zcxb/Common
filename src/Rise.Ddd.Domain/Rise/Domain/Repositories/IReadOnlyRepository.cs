using Rise.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rise.Domain.Repositories
{
    public interface IReadOnlyRepository<TEntity> : IReadOnlyBasicRepository<TEntity>
        where TEntity : class, IEntity
    {
    }

    public interface IReadOnlyRepository<TEntity, TKey> : IReadOnlyRepository<TEntity>, IReadOnlyBasicRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {

    }
}
