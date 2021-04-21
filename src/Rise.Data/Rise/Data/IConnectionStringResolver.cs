using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rise.Data
{
    public interface IConnectionStringResolver
    {
        Task<string> ResolveAsync(string connectionStringName = null);
    }
}
