using System;

namespace Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(2323, "andre", 20,12);
            Jugador j2 = new Jugador(1211 ,"jorge", 25, 12); 
            Jugador j3 = new Jugador(1231, "gabriela", 4, 12);

            Equipo elEquipo = new Equipo(2, "El equipazo");

            
            Console.WriteLine(elEquipo + j1);
            Console.WriteLine(elEquipo + j2);

            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine(j2.MostrarDatos());
        }
    }
}
