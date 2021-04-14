using Rise.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Domain.Repositories
{
    public abstract class RepositoryBase<TEntity> : BasicRepositoryBase<TEntity>, IRepository<TEntity>
        where TEntity : class, IEntity
    {

    }
}
