using System;

namespace Ejercicio_30y36
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1("mini", 12);
            AutoF1 a2 = new AutoF1("cooper", 32);
            AutoF1 a3 = new AutoF1("audi", 52);
            AutoF1 a4 = new AutoF1("jeep", 2);


            Competencia copaPiston = new Competencia(15, 15);
                
            Console.WriteLine(copaPiston + a1);
            Console.WriteLine(copaPiston + a2);
            Console.WriteLine(copaPiston + a3);
            Console.WriteLine(copaPiston + a4);
           // Console.WriteLine(a1.MostrarDatos());
            Console.WriteLine(copaPiston.MostrarDatos());
        
        
        }


    }
}
