using System;

namespace ejercicio6
{
   public class Program
    {
        static void Main(string[] args)
        {
            int primerAno;
            int segundoAno;

            Console.WriteLine("ingrese un año ");
            while ( !int.TryParse(Console.ReadLine(), out primerAno) ) // hace lo mismo de abajo 
            {
                Console.WriteLine("ingrese un año ");
            }

             Console.WriteLine("ingrese un otro año ");
            while ( int.TryParse(Console.ReadLine(), out segundoAno) == false)
            {
                Console.WriteLine("ingrese un otro año ");
            }
            for (int i = primerAno; i <= segundoAno; i++) 
            {
                    if (   i % 4 == 0 && 
                           (i % 100 != 0 || i % 400 == 0)   ) 
                    {
                        Console.WriteLine("este año es bisisesto {0}", i );
                    }


            }





        }
    }
}
