using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.EfCore
{
    public abstract class RiseDbContext<TDbContext> : DbContext, IEfCoreDbContext
        where TDbContext : DbContext
    {
        protected RiseDbContext(DbContextOptions<TDbContext> options)
            : base(options)
        {

        }
    }
}
