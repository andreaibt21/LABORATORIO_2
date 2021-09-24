using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01_Sobrescribiendo_advertencias
{
    public abstract class Sobrescrito
    {
        /*
            Sobrescribir el método ToString para que retorne "¡Este es mi método ToString sobrescrito!".
            Sobrescribir el método Equals para que retorne true si son del mismo tipo (objetos de la misma clase), false caso contrario.
            Sobrescribir el método GetHashCode para que retorne el número 1142510181.
            Agregar en el método Main el siguiente código:
         */
        protected string palabra;
       
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            return obj.GetType() == this.GetType();
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }

                                                  // PARTE DOS
       
        //  Agregar a la clase Sobrescrito un atributo miAtributo del tipo string, con visibilidad protected.
        protected string miAtributo;

        // Generar un constructor de instancia que inicialice miAtributo con el valor "Probar abstractos".
        public Sobrescrito() 
        {
            this.miAtributo = "Probar abstractoddddddds";
        }
        
        //Agregará propiedad abstracta MiPropiedad de sólo lectura. Una vez implementada, retornará el valor de miAtributo.
        public abstract string MiPropiedad { get; }
        
        // Crear un método abstracto MiMetodo que retorne un string. Una vez implementada, retornará el valor de MiPropiedad.
        public abstract string MiMetodo(); //FIRMA 
       
    }
}
