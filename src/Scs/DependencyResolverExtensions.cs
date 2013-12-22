using System.Collections.Generic;
using System.Linq;

namespace Hik
{
    /// <summary>
    /// Generic extension method helpers for <see cref="IDependencyResolver"/>.
    /// </summary>
    public static class DependencyResolverExtensions
    {
        /// <summary>
        /// Resolves dependency of type <typeparamref name="TService" />.
        /// </summary>
        /// <typeparam name="TService">The type of the service.</typeparam>
        /// <param name="resolver">The dependency resolver instance that this method extends.</param>
        /// <returns>The requested service or <c>null</c></returns>
        public static TService GetService<TService>(this IDependencyResolver resolver)
        {
            return (TService)resolver.GetService(typeof(TService));
        }

        /// <summary>
        /// Resolves multiply registered services of type <typeparamref name="TService"/>.
        /// </summary>
        /// <typeparam name="TService">The type of the service.</typeparam>
        /// <param name="resolver">The dependency resolver instance that this method extends.</param>
        /// <returns>The requested services or an empty collection</returns>
        public static IEnumerable<TService> GetServices<TService>(this IDependencyResolver resolver)
        {
            return resolver.GetServices(typeof(TService)).Cast<TService>();
        }
    }
}