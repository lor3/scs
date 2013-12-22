using System;
using Hik.Communication.Scs.Communication.Messages;
using Hik.Communication.ScsServices.Communication.Messages;

namespace Hik.Communication.Scs.Communication.Protocols.BinarySerialization.Messages
{
    /// <summary>
    /// Message factory for BCL-Serialization message implementations.
    /// </summary>
    public class MessageFactory : IMessageFactory
    {
        #region Implementation of IMessageFactory

        /// <inheritdoc />
        public IScsMessage CreateMessage(Type messageType)
        {
            if(messageType == null) throw new ArgumentNullException("messageType");

            if(messageType == typeof(IPingMessage))
                return new ScsPingMessage();

            if(messageType == typeof(IScsRemoteInvokeMessage))
                return new ScsRemoteInvokeMessage();

            if (messageType == typeof(IScsRemoteInvokeReturnMessage))
                return new ScsRemoteInvokeReturnMessage();

            return null;
        }

        /// <inheritdoc />
        public TMessage CreateMessage<TMessage>() where TMessage : class, IScsMessage
        {
            return CreateMessage(typeof (TMessage)) as TMessage;
        }

        #endregion
    }
}
