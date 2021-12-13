using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoBasket : Equipo
    {
        public enum ELiga{ NBA, Euroleague, ACB   }
        private ELiga liga;

        #region CONSTRUCTORES
        /// <summary>
        /// constructores de intanacias
        /// </summary>
        /// <param name="nombre">nombre a asignar</param>
        public EquipoBasket(string nombre)
            : this(nombre, ELiga.NBA)
        {
        }
        /// <summary>
        /// constructores de intanacias
        /// </summary>
        /// <param name="nombre">nombre a asignar</param>
        /// <param name="liga">Liga del equipo tipo enum </param>
        public EquipoBasket(string nombre, ELiga liga )
            : base(nombre)
        {
            this.liga = liga;
        }

        #endregion

        #region METODOS

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Basket - {base.MostrarDatos()}");
            return sb.ToString();

        }
        /// <summary>
        /// GetDificultad retornara un numero Random. Si el equipo es de la liga
        /// NBA, su valor será en 8 y 10. EuroLeague entre 5 y 10, ACB entre 1 y
        /// </summary>
        /// <returns> int</returns>
        public override int GetDificultad()
        {
            int randNumero;
            Random rand = new Random();
            if (this.liga == ELiga.NBA)
            {
                randNumero = rand.Next(8, 10);
               
            }
            if (this.liga == ELiga.Euroleague)
            {
                randNumero = rand.Next(5, 10);

            }
            else
            {
                randNumero = rand.Next(1, 7);

            }
           
            return randNumero;
        }
        //reutilizar el == nombre y tipo en el f competencia
        /// <summary>
        /// ToString hará público MostrarDato
        /// </summary>
        /// <returns> syring con datos del equipo</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion





    }
}
