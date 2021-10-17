using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperExplorador : Trooper
    {
        public string vehiculo;


        #region Constructor


        /// <summary>
        /// Contructor de clase Troooer Explorador
        /// </summary>
        /// <param name="vehiculo"></param>
        public TrooperExplorador(string vehiculo):base(Blaster.EC17)
        {
            this.vehiculo = vehiculo;
        }

        #endregion

        #region METODOS
        public override string infoTrooper()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.infoTrooper()}");
            sb.AppendLine($"  -- Vehivulo   { this.Vehiculo}");
            return sb.ToString();

        }


        #endregion

        #region Propiedades
        /// <summary>
        /// propiedad de lectura y escritura que devuelve el vehiculo
        /// </summary>
        public string Vehiculo
        {
            get
            {
                return this.vehiculo;
            }
            set
            {
                if( value == "")
                {
                    this.vehiculo = "Indefinido";
                }
                else
                {
                    this.vehiculo = value;

                }
            }

        }
        /// <summary>
        /// Propiedad de lectura que devuelve el tipo de trooper
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Soldado de Exploracion";
            }

        }
        #endregion


    }//fin class
}
