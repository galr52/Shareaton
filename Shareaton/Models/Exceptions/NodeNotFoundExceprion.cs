using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Shareaton.Models.Exceptions
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