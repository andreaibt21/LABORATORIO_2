using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Briceno.Andrea._2C
{
    sealed class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora;

        static Automovil ()
        {
            Automovil.valorHora = 120;
        }
       
        public Automovil(string patente, DateTime horaIngreso, string marca)
            : base(horaIngreso, patente)
        {
            this.marca = marca;
        }
        //faltó poner public static
        public static double ValorHora
        {
            set
            {
                if(value > 0)
                {
                    Automovil.valorHora = value;
                }
            }
        }
        //FALTÓ OVERRIDE
        public override  double CostoEstadia
        {
            //ES UNA PROPIEDAD NO UN METODO, POR ESO VA EL GET 
            get 
            {
              return this.CargoDeEstacionamiento(); 
            }
        }

        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Automovil.valorHora;
        }



        public override string Descripcion
        {
                get
                {
                    return this.marca;
                }
        }
        //mostrar datos y to string con mostrar adentro 

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine("****AUTOMOVIL*****");
            sb.AppendLine($"Marca: {Descripcion}");

            return sb.ToString();
            
        }

        public string ToString() 
        {
            return MostrarDatos();


        }

    }//fin class 
}
