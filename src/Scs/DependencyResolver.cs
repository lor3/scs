using System;

namespace Hik
{
    /// <summary>
    /// Provides access to and methods for changing the default <see cref="IDependencyResolver"/>.
    /// </summary>
    public static class DependencyResolver
    {
        /// <summary>
        /// Initializes the <see cref="DependencyResolver"/> class.
        /// </summary>
        static DependencyResolver()
        {
            Current = new DefaultDependencyResolver();
        }

        /// <summary>
        /// Gets the current <see cref="IDependencyResolver"/>.
        /// </summary>
        public static IDependencyResolver Current { get; private set; }

        /// <summary>
        /// Sets the default <see cref="IDependencyResolver"/>.
        /// </summary>
        /// <param name="resolver">The new resolver.</param>
        /// <exception cref="System.ArgumentNullException">resolver</exception>
        public static void SetCurrent(IDependencyResolver resolver)
        {
            if (resolver == null) throw new ArgumentNullException("resolver");
            Current = resolver;
        }
    }
}
