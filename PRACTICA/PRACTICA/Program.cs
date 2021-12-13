using System;

namespace PRACTICA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Reloj reloj = new Reloj();
            reloj.cambioElTiempo += imprimirHora;
            reloj.Ejecutar();

        }
        static void imprimirHora(Reloj reloj)
        {
            Console.Clear();
              Console.WriteLine($"{reloj.hora} : {reloj.minuto} : {reloj.segundos}");

        }



    }
}
