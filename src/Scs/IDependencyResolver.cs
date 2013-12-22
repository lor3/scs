using System;
using System.Collections.Generic;

namespace Hik
{
    /// <summary>
    /// Defines the methods that simplify service location and dependency resolution.
    /// </summary>
    public interface IDependencyResolver
    {
        /// <summary>
        /// Resolves singly registered services that support arbitrary object creation.
        /// </summary>
        /// <param name="type">The type of the requested service or object.</param>
        /// <returns>The requested service, object or <c>null</c> if no matching types were found.</returns>
        object GetService(Type type);

        /// <summary>
        /// Resolves multiply registered services.
        /// </summary>
        /// <param name="type">The type of the requested services.</param>
        /// <returns>The requested service, object or an empty collection if no matching types were found.</returns>
        IEnumerable<object> GetServices(Type type);
    }
}
