using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
   public class Euro
    {

        private double cantidad;
        private static double cotizRespectoDolar;

        #region CONSTRUCTORS
        

        static Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static void SetCotizacion( double cotizacion)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Getters
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion


        #region CASTEADORES
        public static implicit operator Euro(double e)
        {
            Euro aux = new Euro(e);
            return aux;
        }
        
        /// <summary>
        /// Castea de euro a dolar 
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion());
        }
        /// <summary>
        /// Castea de euro a pesos
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Pesos(Euro e)
        {
            Dolar aux = (Dolar)e;
            return (Pesos)aux;


            //return (Pesos)((Dolar)e);//e.cantidad / Euro.GetCotizacion());
        }
        #endregion

        #region OPERATORS
        
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.cantidad == e2.cantidad);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            
            return e == (Euro)d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
           
            return !(e == d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
           
            return e == (Euro)p;

        }
        public static bool operator !=(Euro e, Pesos p)
        {
            
            return !(e == p);
        }


        public static Euro operator +(Euro e, Dolar d)
        {
            Euro aux = new Euro(e.cantidad + ((Euro)d).cantidad);
            return aux;
        }

        public static Euro operator -(Dolar d, Euro e)
        {
            Euro aux = new Euro(e.cantidad - ((Euro)d).cantidad);
            return aux;
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            Euro aux = new Euro(e.cantidad + ((Euro)p).cantidad);
            return aux;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro aux = new Euro(e.cantidad - ((Euro)p).cantidad);
            return aux;
        }


        #endregion

   }
}
