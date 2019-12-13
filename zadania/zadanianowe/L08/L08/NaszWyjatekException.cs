using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace L08
{
    class NaszWyjatekException : Exception
    {
        public NaszWyjatekException()
        {
        }
        public NaszWyjatekException(string message) : base(message)
        {

        }
        NaszWyjatekException(String message, Exception innerException)
          : base(message, innerException)
        {

        }

        NaszWyjatekException(SerializationInfo info, StreamingContext context)
        : base(info, context)
        {

        }
    }
}
