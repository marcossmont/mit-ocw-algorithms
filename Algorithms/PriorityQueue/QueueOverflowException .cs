using System;
using System.Runtime.Serialization;

namespace Algorithms.PriorityQueue
{
    [Serializable]
    internal class QueueOverflowException : Exception
    {
        public QueueOverflowException()
        {
        }

        public QueueOverflowException(string message) : base(message)
        {
        }

        public QueueOverflowException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QueueOverflowException (SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}