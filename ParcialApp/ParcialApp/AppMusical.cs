using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        #region PROPIEDAD
        /// <summary>
        /// La propiedad Tamanio retorna el tamaño de la app, el cual crecerá en base a 
        /// la cantidad de canciones que tenga cargada. 
        /// Por cada canción cargada, su tamaño crecerá en 2mb más.
        /// Por ejemplo: Si la aplicación pesa 50, y tiene 10 canciones, entonces se retornará 70.
        /// </summary>
        protected override int TamanoMb
        {
            get
            {
                int tamanoFinal = 0;
                foreach (string item in listaCanciones)
                {
                    tamanoFinal += 2;
                }
                tamanoFinal += this.tamanoMb;

                return tamanoFinal;
            }
        }

        #endregion

        /// <summary>
        /// Constructor para iniciar un objeto de tipo Appjuegos
        /// </summary>
        /// <param name="nombre"> nombre a asignar</param>
        /// <param name="sistemaOperativo">sistema Operativo a asignar</param>
        /// <param name="tamanoInicial"> tamano a asignar</param>
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanoInicial) 
            : base(nombre, sistemaOperativo, tamanoInicial)
        {
            this.listaCanciones = new List<string>();
        }
        /// <summary>
        /// Constructor para iniciar un objeto de tipo Appjuegos
        /// </summary>
        /// <param name="nombre"> nombre a asignar</param>
        /// <param name="sistemaOperativo">sistema Operativo a asignar</param>
        /// <param name="tamanoInicial">tamano a asignar</param>
        /// <param name="canciones"> canciones a asignar</param>
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanoInicial, List<string> canciones) 
            : this(nombre, sistemaOperativo, tamanoInicial)
        {
            this.listaCanciones = canciones;
        }


        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ObtenerInformacionApp());

            foreach (string item in listaCanciones)
            {
              sb.AppendLine($"Cancion: {item}");
                
            }

            return sb.ToString();
        }
    }
}
