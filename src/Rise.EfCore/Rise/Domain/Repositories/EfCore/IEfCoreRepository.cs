using Rise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rise.Domain.Repositories.EfCore
{
    public interface IEfCoreRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        Task<DbContext> GetDbContextAsync();

        Task<DbSet<TEntity>> GetDbSetAsync();
    }

    public interface IEfCoreRepository<TEntity, TKey> : IEfCoreRepository<TEntity>, IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
    {

    }
}
