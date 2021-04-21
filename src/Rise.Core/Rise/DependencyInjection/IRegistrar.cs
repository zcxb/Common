using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Rise.DependencyInjection
{
    public interface IRegistrar
    {
        void AddAssembly(IServiceCollection services, Assembly assembly);
    }
}
