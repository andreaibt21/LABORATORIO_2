using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppJuegos : Aplicacion
    {

        #region PROPIEDAD
        /// <summary>
        /// la propiedad Tamanio retorna el tamaño de la aplicación.
        /// </summary>
        protected override int TamanoMb
        {
            get 
            {
                return this.tamanoMb;
            }
        }

        #endregion

        #region CONSTRUCTOR

        /// <summary>
        /// Constructor para iniciar un objeto de tipo Appjuegos
        /// </summary>
        /// <param name="nombre"> nombre a asignar</param>
        /// <param name="sistemaOperativo">sistema Operativo a asignar</param>
        /// <param name="tamano"> Tamaño a asignar</param>
        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamano) : base(nombre, sistemaOperativo, tamano)
        {  }
        #endregion

    }
}
