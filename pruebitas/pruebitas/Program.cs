using System;

namespace pruebitas
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero = 23;
            string valorBinario = string.Empty;
            int resultadoDivision = (int)Math.Abs(numero);
          

            if (resultadoDivision >= 0)
            {
                do
                {
                    valorBinario = resultadoDivision % 2 + valorBinario;
                    resultadoDivision /= 2;
                   
                } while (resultadoDivision > 0);
            Console.WriteLine(valorBinario);
            }
          
        }
    }
}
