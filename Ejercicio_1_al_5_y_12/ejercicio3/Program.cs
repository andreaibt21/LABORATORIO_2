using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Mostrar por pantalla todos los números primos que haya hasta el 
             * número que ingrese el usuario por consola.
             * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/

            string ingreso;
            int numeroIngresado;
         
            Console.Title = "EJERCICIO 3";
            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();

            while (int.TryParse(ingreso, out numeroIngresado) == false && numeroIngresado > 0)
            {
                Console.WriteLine("Error, reingrese numero");
                ingreso = Console.ReadLine();
            }
            for (int i = 1; i <= numeroIngresado; i++)
            { 
                if ( (i % (i - 1)) !=  0) {

                    Console.WriteLine("numero primo: {0}", i);
                    i++;
                }
            
            }

        }
    }
}
