using System;
using System.Runtime.Serialization;

namespace Cwiczenie04.exception
{
    public class SzybkoscException : ApplicationException
    {
        public SzybkoscException()
        {
        }

        protected SzybkoscException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public SzybkoscException(string? message) : base(message)
        {
        }

        public SzybkoscException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}