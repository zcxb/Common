using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Rise
{
    public class RiseException : Exception
    {
        public RiseException()
        {

        }

        public RiseException(string message)
            : base(message)
        {

        }

        public RiseException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        public RiseException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
}
