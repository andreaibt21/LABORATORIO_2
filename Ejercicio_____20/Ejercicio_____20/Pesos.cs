using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Pesos()
        {
           cotizRespectoDolar = 1/66;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
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
        public static implicit operator Pesos(double p)
        {
            Pesos aux = new Pesos(p);
            return aux;
        }

        /// <summary>
        /// Castea de pesos a dolar 
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad * Dolar.GetCotizacion());
        }
        /// <summary>
        /// Castea de pesos a euros
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.cantidad * Euro.GetCotizacion());
        }

        #endregion


        #region OPERATORS

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.cantidad == p2.cantidad);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {

            return p == (Pesos)d;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {

            return !(p == d);
        }
        public static bool operator ==(Pesos p, Euro e)
        {

            return p == (Pesos)e;

        }
        public static bool operator !=(Pesos p, Euro e)
        {

            return !(p == e);
        }


        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos aux = new Pesos(p.cantidad + ((Pesos)d).cantidad);
            return aux;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos aux = new Pesos(p.cantidad - ((Pesos)d).cantidad);
            return aux;
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos aux = new Pesos(p.cantidad + ((Pesos)e).cantidad);
            return aux;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos aux = new Pesos(p.cantidad - ((Pesos)e).cantidad);
            return aux;
        }


        #endregion


    }
}
