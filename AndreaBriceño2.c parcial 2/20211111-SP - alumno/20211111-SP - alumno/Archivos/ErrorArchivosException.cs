using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    class ErrorArchivosException : Exception

    {

        private static string mensajeError;

        static ErrorArchivosException()
        {
            mensajeError = "Error en la serializacion";
        }

        public ErrorArchivosException()
        {
        }

        public ErrorArchivosException(string message) : base(message)
        {
        }

        public ErrorArchivosException(string message, Exception innerException) : base(message, innerException)
        {
        }

     
    }
}
