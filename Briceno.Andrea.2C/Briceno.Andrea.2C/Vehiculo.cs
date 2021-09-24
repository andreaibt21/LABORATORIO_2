using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Briceno.Andrea._2C
{
    abstract class Vehiculo
    {

        public enum Tipo { Automovil, Moto };
        //private Tipo tipo; no va
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        protected Vehiculo(DateTime horaIngreso, string patente)
        {
            this.horaIngreso = horaIngreso;
            this.Patente = patente;
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (ValidarPatente(value))
                    this.patente = value;
            }
        }
        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;
            }
            set
            {
                if (value > this.horaIngreso)
                {
                    this.horaEgreso = value;

                }
            }
        }
        public DateTime HoraIngreso
        { get
            {
                return this.horaIngreso;
            }

        }
        //FALTO AGREGAR ABSTRACT
        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; }

        private bool ValidarPatente(string strPatente)
        {
            //faltó validar que no sea null ni vacio  / <8 
            return (strPatente.Length >= 6 && strPatente.Length <= 7);
        }
        protected virtual double CargoDeEstacionamiento()
       {

            double horasAcumuladas = 0;
            horasAcumuladas = (this.horaEgreso - this.horaIngreso).TotalHours;
            return horasAcumuladas;

        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( $" La patente del vehiculo es {Patente}, y la hora de ingreso del vehículo es {HoraIngreso}" );
            return sb.ToString();
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2 )
        {
            return v1.patente == v2.patente;
             
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1== v2);

        }


    }//fin class Vehiculo

}
