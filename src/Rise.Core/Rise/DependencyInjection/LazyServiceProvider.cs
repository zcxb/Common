using System;
using System.Collections.Generic;
using System.Text;

namespace Rise.DependencyInjection
{
    public class LazyServiceProvider : ILazyServiceProvider
    {
        public T LazyGetRequiredService<T>()
        {
            throw new NotImplementedException();
        }

        public object LazyGetRequiredService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public T LazyGetService<T>()
        {
            throw new NotImplementedException();
        }

        public object LazyGetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public T LazyGetService<T>(T defaultValue)
        {
            throw new NotImplementedException();
        }

        public object LazyGetService(Type serviceType, object defaultValue)
        {
            throw new NotImplementedException();
        }

        public object LazyGetService(Type serviceType, Func<IServiceProvider, object> factory)
        {
            throw new NotImplementedException();
        }

        public T LazyGetService<T>(Func<IServiceProvider, object> factory)
        {
            throw new NotImplementedException();
        }
    }
}
