using Common.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain.Repositories
{
    public interface IRepository
    {
    }

    public interface IRepository<TEntity> : IBasicRepository<TEntity>
        where TEntity : class, IEntity
    {

    }

    public interface IRepository<TEntity, TKey> : IRepository<TEntity>, IReadOnlyRepository<TEntity, TKey>, IBasicRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {

    }
}
