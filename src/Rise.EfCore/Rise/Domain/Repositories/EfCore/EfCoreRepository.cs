using Rise.Domain.Entities;
using Rise.EfCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rise.Domain.Repositories.EfCore
{
    public class EfCoreRepository<TDbContext, TEntity> :
        RepositoryBase<TEntity>,
        IEfCoreRepository<TEntity>

        where TDbContext : IEfCoreDbContext
        where TEntity : class, IEntity
    {
        private readonly IDbContextProvider<TDbContext> _dbContextProvider;

        public EfCoreRepository(IDbContextProvider<TDbContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public override async Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            var dbContext = await GetDbContextAsync();

            var savedEntity = (await dbContext.Set<TEntity>().AddAsync(entity)).Entity;

            return savedEntity;
        }

        public override Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public override Task<long> GetCountAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        protected virtual Task<TDbContext> GetDbContextAsync()
        {
            return _dbContextProvider.GetDbContextAsync();
        }

        async Task<DbContext> IEfCoreRepository<TEntity>.GetDbContextAsync()
        {
            return await GetDbContextAsync() as DbContext;
        }

        protected async Task<DbSet<TEntity>> GetDbSetAsync()
        {
            return (await GetDbContextAsync()).Set<TEntity>();
        }

        Task<DbSet<TEntity>> IEfCoreRepository<TEntity>.GetDbSetAsync()
        {
            return GetDbSetAsync();
        }
    }
    public class EfCoreRepository<TDbContext, TEntity, TKey> :
        EfCoreRepository<TDbContext, TEntity>,
        IEfCoreRepository<TEntity, TKey>

        where TDbContext : IEfCoreDbContext
        where TEntity : class, IEntity<TKey>
    {
        public EfCoreRepository(IDbContextProvider<TDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<TEntity> GetAsync(TKey id, CancellationToken cancellationToken = default)
        {
            var entity = await FindAsync(id, cancellationToken);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(TEntity), id);
            }

            return entity;
        }

        public async Task<TEntity> FindAsync(TKey id, CancellationToken cancellationToken = default)
        {
            return await (await GetDbSetAsync()).FindAsync(new object[] { id }, cancellationToken);
        }
    }

}
