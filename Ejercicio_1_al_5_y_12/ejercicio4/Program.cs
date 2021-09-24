using System;

namespace ejercicio4
{
     class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;
            int numero = 1; 
            do 
            {
                for (int i = 1; i < numero; i++) // i = 1 porque abajo tambien se incrementa numero y sigue ingresando 
                {
                    if ((numero % i) == 0 ) 
                    {
                        acumulador += i;
                    }
                }
                if (acumulador == numero) 
                { 
                    Console.WriteLine("NUEMRO PERFECTO: {0}", numero);
                    contador++;
                }
                numero++;
                acumulador = 0;
            } while (contador < 4);

            //SIN RESOLVER



        }
    }
}
