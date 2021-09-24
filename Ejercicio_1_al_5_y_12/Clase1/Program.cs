using System;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Ingresar 5 números por consola, 
             * guardándolos en una variable escalar. Luego 
             * calcular y mostrar: el valor máximo, 
             * el valor mínimo y el promedio.
             */
            string ingreso;
            int numeroIngresado;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int cantidadDeNumeros = 5 ;
            int acumulador = 0;
            float promedio;
            for ( int i = 0; i < cantidadDeNumeros; i++) {
                Console.Title = "EJERCICIO 1";
                Console.WriteLine("Ingrese un numero");
                ingreso = Console.ReadLine();

                /*
                 if (int.TryParse(ingreso, out numeroIngresado) == false ){
                
                }
                 */


                while (int.TryParse(ingreso, out numeroIngresado) == false) 
                {
                    Console.WriteLine("Error, Ingrese un numero");
                }
                if (numeroIngresado > maximo) 
                {
                    maximo = numeroIngresado;
                }
                if (numeroIngresado < minimo)
                {
                    minimo = numeroIngresado;
                }

                acumulador += numeroIngresado;

            }
            promedio = (float)acumulador / cantidadDeNumeros;

            Console.WriteLine("El numero minimo es {0,-3}, maximo {1,-3}, promedio {2, -3:#,###.00}", minimo, maximo, promedio);

            Console.ReadKey();
        }
    }
}
