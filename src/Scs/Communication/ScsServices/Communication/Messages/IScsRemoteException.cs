namespace Hik.Communication.ScsServices.Communication.Messages
{
    /// <summary>
    /// Contains exception information thrown when calling a remote method.
    /// </summary>
    public interface IScsRemoteException
    {
        /// <summary>
        /// Gets the exception message.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Gets the exception stack trace.
        /// </summary>
        string StackTrace { get; }

        /// <summary>
        /// Gets the exception type name.
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Gets the inner exception or <c>null</c>.
        /// </summary>
        IScsRemoteException InnerException { get; }
    }
}
