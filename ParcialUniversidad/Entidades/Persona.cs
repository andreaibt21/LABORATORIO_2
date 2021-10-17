<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento;


        #region CONSTRUCTOR

        /// <summary>
        /// Constructor de la clase Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="documento"></param>
        protected Persona(string nombre, string apellido, string documento)
        {
            this.apellido = apellido;
            this.documento = documento;
            this.nombre = nombre;
        }
        #endregion


        #region PROPERTIES

        /// <summary>
        /// Propiedad de retorno apellido
        /// </summary>
        public string Apellido
        {
            get {
                return this.apellido; 
            }
         
        }
        /// <summary>
        /// propiedad de lectura y escritura  del atributo Documento
        /// </summary>
        public string Documento
        {
            get { 
                return this.documento; 
            }
            set {

                if ( string.IsNullOrWhiteSpace(value) && ValidarDocumentacion(value))
                {
                    this.documento = value; 

                }
            }
        }

        /// <summary>
        /// Propiedad de lectura  del atributo  nombre
        /// </summary>
        public string Nombre
        {
            get { 
                return this.nombre; 
            }
           
        }
         #endregion

        #region METODOS

        /// <summary>
        /// retorna los datos de la clase dónde se lo coloque, utilizando StringBuilder para compilar dicha información.
        /// </summary>
        /// <returns> String con datos de la persona </returns>
        public virtual string ExponerDatos()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine( $"Nombre {this.Nombre}");
            sb.AppendLine($"Apellido {this.Apellido}");
            sb.AppendLine($"Documento {this.Documento}");

            return sb.ToString();
        }


        /// <summary>
        /// firma del metodo 
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        protected abstract bool ValidarDocumentacion(string doc);
       
            


        #endregion



    }//fin class
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento;


        #region CONSTRUCTOR

        /// <summary>
        /// Constructor de la clase Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="documento"></param>
        protected Persona(string nombre, string apellido, string documento)
        {
            this.apellido = apellido;
            this.documento = documento;
            this.nombre = nombre;
        }
        #endregion


        #region PROPERTIES

        /// <summary>
        /// Propiedad de retorno apellido
        /// </summary>
        public string Apellido
        {
            get {
                return this.apellido; 
            }
         
        }
        /// <summary>
        /// propiedad de lectura y escritura  del atributo Documento
        /// </summary>
        public string Documento
        {
            get { 
                return this.documento; 
            }
            set {

                if ( string.IsNullOrWhiteSpace(value) && ValidarDocumentacion(value))
                {
                    this.documento = value; 

                }
            }
        }

        /// <summary>
        /// Propiedad de lectura  del atributo  nombre
        /// </summary>
        public string Nombre
        {
            get { 
                return this.nombre; 
            }
           
        }
         #endregion

        #region METODOS

        /// <summary>
        /// retorna los datos de la clase dónde se lo coloque, utilizando StringBuilder para compilar dicha información.
        /// </summary>
        /// <returns> String con datos de la persona </returns>
        public virtual string ExponerDatos()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine( $"Nombre {this.Nombre}");
            sb.AppendLine($"Apellido {this.Apellido}");
            sb.AppendLine($"Documento {this.Documento}");

            return sb.ToString();
        }


        /// <summary>
        /// firma del metodo 
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        protected abstract bool ValidarDocumentacion(string doc);
       
            


        #endregion



    }//fin class
}
>>>>>>> f113d24e9a85b79fb19b5978cb951a85bd68363d
