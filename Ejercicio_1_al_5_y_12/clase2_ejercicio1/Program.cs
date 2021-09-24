using System;

namespace clase2_ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 11. Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la
                  siguiente firma: bool Validar(int valor, int min, int max):
                  a. valor: dato a validar
                  b. min y max: rango en el cual deberá estar la variable valor.
                  Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
                  anteriormente que estén dentro del rango -100 y 100.
                  Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
                  Nota: Utilizar variables escalares, NO utilizar vectores.
              */
            int numeroIngresado;
            string ingreso;
            int cantidadDeNumeros = 10;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int acumulador = 0;
            float promedio;

            Console.Title = "EJERCICIO 11";

            for (int i = 0; i < cantidadDeNumeros; i++) {

                Console.WriteLine("{0} Ingrese un numero" , i);
                ingreso = Console.ReadLine();

                while (int.TryParse(ingreso, out numeroIngresado) == false || Validacion.Validar(numeroIngresado, -100, 100) == false )
                {
                    Console.WriteLine("Error, Ingrese un numero");
                    ingreso = Console.ReadLine();
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


         






        }



    }
}
