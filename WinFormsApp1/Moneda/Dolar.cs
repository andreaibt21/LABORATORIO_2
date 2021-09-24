using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda

{
    public class Dolar
    {

        // Dolar primerDolar = new Dolar();     
         
        private static double cotizRespectoDolar;
        private double cantidad;


        #region Constructores
        static Dolar() {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        //private Dolar(double cantidad, double cotizRespectoDolar)  {     }     NO VA 
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
        
        //public static bool operator nombre Tipo()       


        #region conversiones de dolar a euro y pesos 
       

        public static implicit operator Dolar(double d)
        {
            Dolar aux = new Dolar(d);
            return aux;
        }

        /// <summary>
        /// Castea de dolar a euro 
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro (Dolar d)
        {   
               return new Euro( d.cantidad * Euro.GetCotizacion());
        }
        /// <summary>
        /// Castea de dolar a pesos
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        #endregion

        #region OPERATORS
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return ( d1.cantidad == d2.cantidad );
        }

        public static bool operator != (Dolar d1, Dolar d2)
        {
            return !(d1 ==d2);
        }

        public static bool operator == (Dolar d, Euro e)
        {
            //return ( d.GetCantidad() == (Dolar)e.GetCantidad() );
            return d == (Dolar)e;
        }
        public static bool operator != (Dolar d, Euro e) 
        {
           //return ( d.GetCantidad() != (Dolar)e.GetCantidad() );
            //return d != (Dolar)e;
            return !(d == e);
        }
        public static bool operator != (Dolar d, Pesos p)
        {
            //return ( d.GetCantidad() != p.GetCantidad() );
            return d != (Dolar)p;
        }
        public static bool operator == (Dolar d, Pesos p)
        {
            //return ( d.GetCantidad() == p.GetCantidad() );
            //return d == (Dolar)p;
            return !(d == p);

        }
     

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar aux = new Dolar(d.cantidad + ((Dolar)e).cantidad);
            return aux;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar aux = new Dolar(d.cantidad -((Dolar)e).cantidad);
            return aux;
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return aux;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return aux;
        }

        #endregion

    }


}
