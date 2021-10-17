using System;
using Ejercicio_48;

namespace Prueba
{
    public class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura(1);
            Factura f2 = new Factura(2);
            Factura f3 = new Factura(3);
            Factura f4 = new Factura(4);
            Recibo r1 = new Recibo();
            Recibo r2 = new Recibo(5);
            Recibo r3 = new Recibo(6);
            Recibo r4 = new Recibo(7);

            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            c += f1;
            c += f2;
            c += f3;
            c += f4;
            c += r1;
            c += r2;
            c += r3;
            c += r4;
            Console.WriteLine(c.Mostrar());




            Console.ReadKey();
        }
    }
}
