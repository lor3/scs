using System;

namespace Hik.Communication.Scs.Communication.Messages
{
    /// <summary>
    /// Facilitates instantiation transport independent message packets.
    /// </summary>
    public interface IMessageFactory
    {
        /// <summary>
        /// Creates the message of type <paramref name="messageType" />.
        /// </summary>
        /// <param name="messageType">Type of the message.</param>
        /// <returns> a new instance of the specified type, or <c>null</c> if unknown</returns>
        IScsMessage CreateMessage(Type messageType);

        /// <summary>
        /// Creates the message of type <typeparamref name="TMessage"/>.
        /// </summary>
        /// <typeparam name="TMessage">The type of the message.</typeparam>
        /// <returns>a new instance of the specified type, or <c>null</c> if unknown</returns>
        TMessage CreateMessage<TMessage>() where TMessage : class, IScsMessage;
    }
}
