using System;
using System.Runtime.Serialization;

namespace Shareaton.Data.Exceptions
{
    [Serializable]
    internal class NodeNotFoundException : Exception
    {
        public NodeNotFoundException()
        {
        }

        public NodeNotFoundException(string message) : base(message)
        {
        }

        public NodeNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NodeNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}