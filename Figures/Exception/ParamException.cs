using System;
using System.Runtime.Serialization;

namespace Figures
{
    public class ParamException : Exception
    {
        public ParamException()
        {
        }

        public ParamException(string message) : base(message)
        {
        }

        public ParamException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParamException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
