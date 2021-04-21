using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionCommonExtensions
    {
        public static T GetInstanceOrNull<T>(this IServiceCollection services)
        {
            return (T)services
                .FirstOrDefault(d => d.ServiceType == typeof(T))
                ?.ImplementationInstance;
        }

        public static T GetInstance<T>(this IServiceCollection services)
        {
            var service = services.GetInstanceOrNull<T>();
            if (service == null)
            {
                throw new InvalidOperationException("Could not find service: " + typeof(T).AssemblyQualifiedName);
            }

            return service;
        }
    }
}
