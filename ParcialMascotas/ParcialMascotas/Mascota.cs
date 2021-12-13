using System;
using System.Text;

namespace ParcialMascotas
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;

        /// <summary>
        /// constructor de la clase mascota 
        /// </summary>
        /// <param name="nombre">nombre a asignar</param>
        /// <param name="raza">raza a asignar</param>
        protected Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        /// <summary>
        /// propiedad de tipo lectura del atributo nombre
        /// </summary>
        public string Nombre{ 
            get {
                return this.nombre;}
        }
        /// <summary>
        /// propiedad de tipo lectura del atributo raza
        /// </summary>
        public string Raza { 
            get { return this.raza; } 
        }
        /// <summary>
        /// Firma del metodo FICHA
        /// </summary>
        /// <returns></returns>
        protected abstract string Ficha();
        /// <summary>
        /// Metodo que devuelve los datos de la mascota 
        /// </summary>
        /// <returns></returns>
        protected virtual string DatosCompletos()
        {
            string datos = String.Format("NOMBRE: {0}, RAZA: {1} ", this.nombre,this.raza );
            return datos;
        }


    }//fin clase
}
