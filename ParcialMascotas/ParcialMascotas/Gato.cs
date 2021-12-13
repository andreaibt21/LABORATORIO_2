using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialMascotas
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) 
            : base(nombre, raza)
        {
        }


        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("    Gato");
            sb.AppendLine($"{base.DatosCompletos()}");
            return sb.ToString();
        }

        #region Operadores
        /// <summary>
        /// Dos Gatos serán iguales si comparten nombre, raza
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Gato j1, Gato j2)
        {

            return (j1.Nombre == j2.Nombre && j1.Raza == j2.Raza);

        }

        public static bool operator !=(Gato j1, Gato j2)
        {
            return !(j1 == j2);
        }
        #endregion

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Gato)  //si el objeto es perro 
            {
                retorno = (Gato)obj == this; // casteamos el objeto para que sea de tipo perro y lo comparamos con el perro donde se está llamando
            }
            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

    }
}
