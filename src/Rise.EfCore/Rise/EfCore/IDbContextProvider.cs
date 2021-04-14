using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rise.EfCore
{
    public interface IDbContextProvider<TDbContext>
        where TDbContext : IEfCoreDbContext
    {
        Task<TDbContext> GetDbContextAsync();
    }
}
