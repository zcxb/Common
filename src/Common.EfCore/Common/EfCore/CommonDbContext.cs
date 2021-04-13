using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.EfCore
{
    public abstract class CommonDbContext<TDbContext> : DbContext, IEfCoreDbContext
        where TDbContext : DbContext
    {
        protected CommonDbContext(DbContextOptions<TDbContext> options)
            : base(options)
        {

        }
    }
}
