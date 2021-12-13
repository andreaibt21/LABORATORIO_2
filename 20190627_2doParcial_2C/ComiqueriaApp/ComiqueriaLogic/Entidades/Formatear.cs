using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public static class Formatear
    {
       /// <summary>
       ///  extienda el tipo Double
       /// y devuelva un string con el valor formateado con 2 decimales y el signo $ por delante.
       /// </summary>
      public static string FormatearPrecio(this double precio)
        {
            string dosDecimales = precio.ToString("0.##");
            return $"$precio{dosDecimales}";
        }
    }
}
