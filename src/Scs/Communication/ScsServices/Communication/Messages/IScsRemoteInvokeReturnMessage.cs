using Hik.Communication.Scs.Communication.Messages;

namespace Hik.Communication.ScsServices.Communication.Messages
{
    /// <summary>
    /// Message is sent as response message to a ScsRemoteInvokeMessage.
    /// </summary>
    public interface IScsRemoteInvokeReturnMessage : IScsMessage
    {
        /// <summary>
        /// Return value of remote method invocation.
        /// </summary>
        object ReturnValue { get; set; }

        /// <summary>
        /// If any exception occurred during method invocation, this field contains Exception object.
        /// If no exception occurred, this field is null.
        /// </summary>
        IScsRemoteException RemoteException { get; set; }
    }
}
