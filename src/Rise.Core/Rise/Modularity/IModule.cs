using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.Modularity
{
    public interface IModule
    {
        void ConfigureServices(ServiceConfigurationContext context);
    }
}
