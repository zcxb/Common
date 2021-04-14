﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rise.EfCore
{
    public interface IEfCoreDbContext : IDisposable
    {
        EntityEntry<TEntity> Attach<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Attach(object entity);

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        DbSet<T> Set<T>() where T : class;

        DatabaseFacade Database { get; }

        ChangeTracker ChangeTracker { get; }

        EntityEntry Add(object entity);

        EntityEntry<TEntity> Add<TEntity>(TEntity entity) where TEntity : class;

        ValueTask<EntityEntry> AddAsync(object entity, CancellationToken cancellationToken = default);

        ValueTask<EntityEntry<TEntity>> AddAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default) where TEntity : class;

        void AddRange(IEnumerable<object> entities);

        void AddRange(params object[] entities);

        Task AddRangeAsync(params object[] entities);

        Task AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default);

        void AttachRange(IEnumerable<object> entities);

        void AttachRange(params object[] entities);

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Entry(object entity);

        object Find(Type entityType, params object[] keyValues);

        TEntity Find<TEntity>(params object[] keyValues) where TEntity : class;

        ValueTask<object> FindAsync(Type entityType, object[] keyValues, CancellationToken cancellationToken);

        ValueTask<TEntity> FindAsync<TEntity>(object[] keyValues, CancellationToken cancellationToken) where TEntity : class;

        ValueTask<TEntity> FindAsync<TEntity>(params object[] keyValues) where TEntity : class;

        ValueTask<object> FindAsync(Type entityType, params object[] keyValues);

        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Remove(object entity);

        void RemoveRange(IEnumerable<object> entities);

        void RemoveRange(params object[] entities);

        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry Update(object entity);

        void UpdateRange(params object[] entities);

        void UpdateRange(IEnumerable<object> entities);
    }
}
