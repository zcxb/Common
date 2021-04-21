using Rise.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.EfCore.DependencyInjection
{
    public static class DbContextOptionsFactory
    {
        private static void GetCreationContext<TDbContext>(IServiceProvider serviceProvider)
            where TDbContext : RiseDbContext<TDbContext>
        {
            var connectionStringName = ConnectionStringNameAttribute.GetConnStringName<TDbContext>();
        }
    }
}
