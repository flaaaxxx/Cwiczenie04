using System;
using System.Runtime.Serialization;

namespace Cwiczenie04.exception
{
    public class PrzezroczystoscException : ApplicationException
    {
        public PrzezroczystoscException()
        {
        }

        protected PrzezroczystoscException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public PrzezroczystoscException(string? message) : base(message)
        {
        }

        public PrzezroczystoscException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}