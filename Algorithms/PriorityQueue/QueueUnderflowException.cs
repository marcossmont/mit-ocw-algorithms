using System;
using System.Runtime.Serialization;

namespace Algorithms.PriorityQueue
{
    [Serializable]
    internal class QueueUnderflowException : Exception
    {
        public QueueUnderflowException()
        {
        }

        public QueueUnderflowException(string message) : base(message)
        {
        }

        public QueueUnderflowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QueueUnderflowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}