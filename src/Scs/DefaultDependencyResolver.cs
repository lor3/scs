using System;
using System.Collections.Generic;

namespace Hik
{
    internal class DefaultDependencyResolver : IDependencyResolver
    {


        #region Implementation of IDependencyResolver

        public object GetService(Type type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetServices(Type type)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
