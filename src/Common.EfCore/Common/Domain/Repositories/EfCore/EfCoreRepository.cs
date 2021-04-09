using Common.Domain.Entities;
using Common.EfCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common.Domain.Repositories.EfCore
{
    public class EfCoreRepository<TDbContext, TEntity> : RepositoryBase<TEntity>
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
    }

    public class EfCoreRepository<TDbContext, TEntity, TKey>
    {

    }
}
