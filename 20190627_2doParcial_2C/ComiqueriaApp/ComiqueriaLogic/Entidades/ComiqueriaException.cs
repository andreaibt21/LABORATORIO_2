using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public class ComiqueriaException : Exception
    {
        public ComiqueriaException()
        {
        }

        public ComiqueriaException(string message) : base(message)
        {
        }

        public ComiqueriaException(string message, Exception innerException) : base(message, innerException)
        {
        }

      
    }
}
