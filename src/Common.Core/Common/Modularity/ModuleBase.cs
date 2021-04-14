using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Modularity
{
    public abstract class ModuleBase : IModule
    {
        public virtual void ConfigureServices()
        {
        }
    }
}
