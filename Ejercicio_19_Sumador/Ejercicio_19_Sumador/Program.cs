using System;

namespace Ejercicio_19_Sumador
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador cuenta1 = new Sumador();
            Sumador cuenta2 = new Sumador();

            Console.WriteLine(cuenta1.Sumar(32, 23));
            Console.WriteLine(cuenta1.Sumar("que ondis", "chao"));

            Console.WriteLine(cuenta2.Sumar(32, 23));
            Console.WriteLine(cuenta2.Sumar("qlq", "2"));
            

            Console.WriteLine("ES UN NUMERO {0}", (int)cuenta1); //creacion de casteo 
            Console.WriteLine(cuenta1 + cuenta2);
            Console.WriteLine(cuenta1 | cuenta2);


        }
    }
}
