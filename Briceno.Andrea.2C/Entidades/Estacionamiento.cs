using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private int capacidadEstacionamiento;
        private string nombre;

        private Estacionamiento(int capacidadEstacionamiento, string nombre)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.capacidadEstacionamiento = capacidadEstacionamiento;
            this.nombre = nombre;
        }

        public string Nombre {
            get
            {
                return this.nombre;
            }
        }

        internal List<Vehiculo> ListadoVehiculos {
            get 
            { 
                return this.listadoVehiculos;
            } 
            
        
        }

        /*
        * GetEstacionamiento será de clase e implementará un patrón singleton para lo
        cual deberá:
        i. Si la variable estacionamiento es null, instanciar el objeto.
        ii. Si no es null, modificara la capacidad del estacionamiento.
        iii. En ambos casos, su última acción será retornar el objeto
        estacionamiento.
         */
        public static Estacionamiento GetEstacionamieno(string nombre, int capacidad)
        { 
            if (Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(capacidad, nombre);
            }
            else
            {   
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
                return Estacionamiento.estacionamiento;
        }

        //public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        //{
        //    return v1.patente == v2.patente;

        //}

        static string InformormarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Retiro Estacionamiento {Estacionamiento.estacionamiento.Nombre}");
          //  sb.AppendLine($"{vehiclo.}");

            return sb.ToString();


        }



    } //fin class estacionamiento

}
