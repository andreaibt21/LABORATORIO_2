using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01_Sobrescribiendo_advertencias
{
    public class SobreSobrescrito : Sobrescrito
    {
        /*
           Agregar una clase llamada SobreSobrescrito que herede de Sobrescrito. Implementar el código
           necesario para que todo funcione correctamente.
           Modificar el método Main para probar las modificaciones.
        
        */
        //Agregará propiedad abstracta MiPropiedad de sólo lectura. Una vez implementada, retornará el valor de miAtributo.
        public override string MiPropiedad 
        {
            get
            {
                return this.miAtributo;
            }
        }

        // Crear un método abstracto MiMetodo que retorne un string. Una vez implementada, retornará el valor de MiPropiedad.
        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
