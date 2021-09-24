using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
                mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
                Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
                */
            string ingreso;
            int numeroIngresado;
            double cuadrado;
            double cubo; 

           
                Console.Title = "EJERCICIO 2";
                Console.WriteLine("Ingrese un numero");
                ingreso = Console.ReadLine();
               
                while (int.TryParse(ingreso, out numeroIngresado) == false  && numeroIngresado > 0)
                {
                    Console.WriteLine("Error, reingrese numero");
                }
                cuadrado = Math.Pow(numeroIngresado, 2);
                cubo = Math.Pow(numeroIngresado, 3);

            
            

            Console.WriteLine("El numero ingresado es {0,-3}, cuadrado {1,-3}, cubo {2, -3}", numeroIngresado, cuadrado, cubo );

            Console.ReadKey();
        }
    }
}
