using System;

namespace Billetes

{
    class Program
    {
        static void Main(string[] args)
        {
            Euro e = new Euro(10);
            Dolar d = new Dolar(10);
            Pesos p = new Pesos(10);

            Euro e1 = (Euro)p;

            

            Console.WriteLine($"  {d.GetCantidad()} pesos en euros es {e1.GetCantidad()}");
            
            

            Console.ReadKey();

        }
    }
}
