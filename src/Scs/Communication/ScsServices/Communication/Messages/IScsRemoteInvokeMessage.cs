using Hik.Communication.Scs.Communication.Messages;

namespace Hik.Communication.ScsServices.Communication.Messages
{
    /// <summary>
    /// Message is sent to invoke a method of a remote application.
    /// </summary>
    public interface IScsRemoteInvokeMessage : IScsMessage
    {
        /// <summary>
        /// Name of the remove service class.
        /// </summary>
        string ServiceClassName { get; }

        /// <summary>
        /// Method of remote application to invoke.
        /// </summary>
        string MethodName { get; }

        /// <summary>
        /// Parameters of method.
        /// </summary>
        object[] Parameters { get; }
    }
}
