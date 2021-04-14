using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Modularity
{
    public abstract class ModuleBase : IModule
    {

        protected internal ServiceConfigurationContext ServiceConfigurationContext { get; internal set; }

        public virtual void ConfigureServices(ServiceConfigurationContext context)
        {
        }

        protected void Configure<TOptions>(Action<TOptions> configureOptions)
            where TOptions : class
        {
            ServiceConfigurationContext.Services.Configure(configureOptions);
        }
    }
}
