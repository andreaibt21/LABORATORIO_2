using System;
using System.Text;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {

        private bool jugadoresEstrella;

        #region CONSTRUCTORES
        /// <summary>
        /// constructores de intanacias
        /// </summary>
        /// <param name="nombre">nombre a asignar</param>
        public EquipoFutbol(string nombre)
            : this(nombre, false)
        {
        }
        /// <summary>
        /// constructores de intanacias
        /// </summary>
        /// <param name="nombre">nombre a asignar</param>
        /// <param name="jugadoresEstrella">true o false si contiene jugadores estrella</param>
        public EquipoFutbol(string nombre, bool jugadoresEstrella)
            : base(nombre)
        {
            this.jugadoresEstrella = jugadoresEstrella;
        }


        #endregion

        #region METODOS

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Futbol - {base.MostrarDatos()}");
            return sb.ToString();

        }
        /// <summary>
        /// GetDificultad retornará un numero Random entre 7 y 10. En caso de
        ///poseer “jugadoresEstrellas” este valor se deberá de duplicar
        /// </summary>
        /// <returns>int </returns>
        public override int GetDificultad()
        {

            Random rand = new Random();

            int randNumero;
                randNumero = rand.Next(7, 10);

            if (this.jugadoresEstrella == true)
            {
                randNumero *= 2;
            }
           
            return randNumero;
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion
    }//fin class
}
