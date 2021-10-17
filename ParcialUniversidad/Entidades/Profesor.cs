using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor de la clase profesor
        /// </summary>
        /// <param name="nombre"> valor a asignar </param>
        /// <param name="apellido"> valor a asignar</param>
        /// <param name="documento"> valor a asignar</param>
        public Profesor(string nombre, string apellido, string documento) 
            : base(nombre, apellido, documento)
        {
        }

        /// <summary>
        /// Constructor de la clase Profesor
        /// </summary>
        /// <param name="nombre"> valor a asignar</param>
        /// <param name="apellido"> valor a asignar</param>
        /// <param name="documento"> valor a asignar</param>
        /// <param name="fechaIngreso"> valor a asignar</param>
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
           : this(nombre, apellido, documento)
        {
            this.FechaIngreso = fechaIngreso;
        }

        public DateTime FechaIngreso { get => FechaIngreso1; set => FechaIngreso1 = value; }
        public DateTime FechaIngreso1 { get => fechaIngreso; set => fechaIngreso = value; }
        #endregion

        #region PROPIEDADES


        /// <summary>
        /// Antigüedad devolverá la cantidad de tiempo, en días, desde la fecha de ingreso del profesor hasta la
        //actualidad.
        /// </summary>
        public int Antiguedad
        {
            get
            {
               return (DateTime.Now - this.fechaIngreso).Days;
                
            }
        }


        /// <summary>
        /// ValidarDocumentacion dará como válido cuando el documento tenga exactamente 8 caracteres.
        /// 
        /// </summary>
        /// <param name="doc"></param>
        /// <returns>bool</returns>
       protected override bool ValidarDocumentacion(string doc)
        {
            bool auxReturn = false;
            if ((!string.IsNullOrWhiteSpace(doc)) && doc.Length == 8)
            {
                foreach (char c in doc)
                {
                    if (!(char.IsDigit(c)))
                    {
                        return auxReturn;
                    }
                }
                auxReturn = true;
            }
            return auxReturn;
        }


        /// <summary>
        /// retorna los datos de un alumno
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine($"Antiguedad {this.Antiguedad}");
            sb.AppendLine($"Fecha de ingreso {this.fechaIngreso}");

            return sb.ToString();
        }
        #endregion


    }//fin class
}
