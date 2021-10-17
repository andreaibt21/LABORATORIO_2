using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Trooper
    {
        protected Blaster armamento;
        protected bool esClon;

        #region CONTRUCTOR

        /// <summary>
        /// Constructor de la clase trooper
        /// </summary>
        /// <param name="armamento"></param>
       /* public Trooper(Blaster armamento)
        {
            this.armamento = armamento;
            this.esClon = false;
        }
       */
        public Trooper(Blaster armamento)
            : this(armamento,false)
        {
        }



        /// <summary>
        /// Constructpr de la clase trooper
        /// </summary>
        /// <param name="armamento"></param>
        /// <param name="esClon"></param>
        /// 
      /*  public Trooper(Blaster armamento, bool esClon) : this(armamento)
        {
            this.esClon = esClon;   //estas haciendo doble 
        }*/

        public Trooper(Blaster armamento, bool esClon) 
        {
            this.esClon = esClon;
            this.armamento = armamento;
        }
        #endregion


        #region PROPIEDADDES

        /// <summary>
        ///  propiedad de lectura 
        /// </summary>
        public Blaster Armamento
        {
            get {
                return armamento; //galtó el this.
            }

        }
        /// <summary>
        /// propiedad de lectura y escritura 
        /// </summary>
        public bool EsClon
        {
            get
            {
                return this.esClon;
            }
            set
            {
                this.esClon = value;

            }

        }


         public abstract string Tipo { get; }
        #endregion

        #region METODOS

        /// <summary>
        /// InfoTrooper retornará la información del soldado
        /// </summary>
        /// <returns></returns>
        public virtual string infoTrooper()
        {
            string sino;
            if(this.EsClon == true)
            {
                sino = "SI";
            }
            else
            {
                sino = "NO";
            }
           string sb =  String.Format(" {0} armado con {1}, {2} es clone.", this.Tipo, this.Armamento, sino);
            return sb;
           
        }


        /// <summary>
        /// retornará TRUE si ambos objetos son del tipo TYPE.
        /// </summary>
        /// <param name="obj">objeto a comparar</param>
        /// <returns> true si son iguales, false si no</returns>
        public override bool Equals(object obj)
        {
            return (this.GetType() == obj.GetType());
      

        }
 
           



        #endregion

    }// fin class
}
