using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Expeciones : Exception
    {
        public Expeciones()
        {
        }

        public Expeciones(string message) : base(message)
        {
        }

        public Expeciones(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Expeciones(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
