using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19_Sumador
{
    public class Sumador
    {
        public int cantidadSumas;

        public  Sumador (int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() 
            : this(0)    //hace referencia al constructor principal. se inicializa en 0 
        {   }
        public void Sumar()
        {
            this.cantidadSumas++ ;
        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;

            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + " " + b;
        }

        public static  explicit operator int(Sumador sumas) // CASTEO DE UN OBJETO A INT 
        {
            return sumas.cantidadSumas;

        }
        /// <summary>
        /// suma la cantidad de sumas hechas entre s1 y s2 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static long operator + (Sumador s1, Sumador s2 ) //sin escribir el coso de parentesis 
        {

            return (long)(s1.cantidadSumas + s2.cantidadSumas);
            
            
        }
        /// <summary>
        /// Compara si s1 y s2 tienen la misma cantidad de sumas hechas
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator |(Sumador s1, Sumador s2) 
        {
            return (s1.cantidadSumas == s2.cantidadSumas);

        }

    }
}
