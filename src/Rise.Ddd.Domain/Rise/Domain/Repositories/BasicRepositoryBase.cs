using Rise.Domain.Entities;
using Rise.Threading;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rise.Domain.Repositories
{
    public abstract class BasicRepositoryBase<TEntity> :
        IBasicRepository<TEntity>
        where TEntity : class, IEntity
    {
        public ICancellationTokenProvider CancellationTokenProvider;

        protected BasicRepositoryBase()
        {

        }

        public abstract Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default);

        public async Task InsertAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            foreach (var entity in entities)
            {
                await InsertAsync(entity);
            }
        }

        public abstract Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

        public async Task UpdateAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            foreach (var entity in entities)
            {
                await UpdateAsync(entity);
            }
        }

        public abstract Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);

        public async Task DeleteAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            foreach (var entity in entities)
            {
                await DeleteAsync(entity);
            }
        }

        public abstract Task<long> GetCountAsync(CancellationToken cancellationToken = default);

    }
}
