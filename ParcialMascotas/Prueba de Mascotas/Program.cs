using System;
using ParcialMascotas;


namespace Prueba_de_Mascotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo animalitos = new Grupo("Animalitos", Grupo.TipoManada.Unica);
            Gato g1 = new Gato("michi", "r1");
            Gato g2 = new Gato("michi2", "r2");
            Gato g3 = new Gato("michi3", "r4");
            Gato g4 = new Gato("michi4", "r1");
            Perro p1 = new Perro("Tony", "r2",2,true);
            Perro p2 = new Perro("Bumi", "r3",4,false);
            Perro p3 = new Perro("Lunis", "r1",2, true);
            Perro p4 = new Perro("Tazu", "r1", 4, false);

            animalitos += g1;
            animalitos += g2;
            animalitos += g3;
            animalitos += g4;
            animalitos += p1;
            animalitos += p2;
            animalitos += p3;
            animalitos += p4;

            Console.WriteLine( animalitos.ToString());




        }
    }
}
