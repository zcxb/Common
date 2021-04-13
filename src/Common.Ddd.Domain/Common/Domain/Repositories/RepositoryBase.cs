using Common.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Domain.Repositories
{
    public abstract class RepositoryBase<TEntity> : BasicRepositoryBase<TEntity>, IRepository<TEntity>
        where TEntity : class, IEntity
    {

    }
}
