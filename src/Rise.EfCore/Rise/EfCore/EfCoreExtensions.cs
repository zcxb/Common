using Microsoft.EntityFrameworkCore;
using Rise.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Rise.EfCore
{
    public static class EfCoreExtensions
    {
        public static IQueryable<TEntity> GetById<TEntity>(this IQueryable<TEntity> query, int id)
            where TEntity : AuditedModelBase
        {
            return query.Where(i => i.Id == id);
        }

        public static void RemoveRange<TEntity>(this DbSet<TEntity> set, int[] keyValues)
           where TEntity : AuditedModelBase
        {
            var entities = set.Where(i => keyValues.Contains(i.Id));
            set.RemoveRange(entities);
        }

        public static void RemoveRange<TEntity>(this DbSet<TEntity> set, Expression<Func<TEntity, bool>> predicate)
            where TEntity : AuditedModelBase
        {
            set.RemoveRange(set.Where(predicate));
        }
    }
}
