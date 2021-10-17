using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperAsalto : Trooper
    {
        #region PROPIEDADES


        /// <summary>
        /// Propiedad de lectura que devuelve el tipo de trooper
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Comando para misiones de infiltración";
            }

        }

        #endregion


        #region Constructor
        /// <summary>
        ///  Constructor de la clase trooperAsalto
        /// </summary>
        /// <param name="armamento"></param>
        public TrooperAsalto(Blaster armamento)
            : base(armamento, true)
        {
        }
        #endregion



    }
}
