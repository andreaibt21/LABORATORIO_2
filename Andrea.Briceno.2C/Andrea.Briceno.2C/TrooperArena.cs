using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperArena : Trooper
    {


        #region PROPIEDADES
       

        /// <summary>
        /// Propiedad de lectura que devuelve el tipo de trooper
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Soldados de asalto de terrenos desérticos";
            }

        }

        #endregion


        #region Constructor
        /// <summary>
        ///  Constructor de la clase trooperArena
        /// </summary>
        /// <param name="armamento"></param>
        public TrooperArena(Blaster armamento)
            : base(armamento)
        {
        }
        #endregion


    }
}
