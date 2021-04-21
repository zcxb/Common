using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rise.Data
{
    public class DefaultConnectionStringResolver : IConnectionStringResolver
    {
        public DefaultConnectionStringResolver()
        {

        }

        public virtual Task<string> ResolveAsync(string connectionStringName = null)
        {
            throw new NotImplementedException();
        }
    }
}
