using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialMascotas
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza)
            : this(nombre, raza, 0, false)
        {

        }
        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public int Edad {
            get
            {
                return this.edad;
            }

            set
            {
                this.edad = value;
            }
        }
        public bool EsAlfa {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }

        /// <summary>
        ///Retornará toda la información del Perro con el siguiente formato:
        ///Si es alfa: Ramón Salchicha, alfa de la manada, edad 2
        ///si no lo es: Julio Cruza edad 13
        /// </summary>
        /// <returns>string</returns>
        protected override string Ficha()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("    Perro");

            //sb.Append($"  {base.DatosCompletos()}");
            //if (this.EsAlfa)
            //{
            //    sb.Append("alfa de la manada");
            //}
            //sb.Append($" edad {this.Edad}");

            //return sb.ToString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"perro - ");
            stringBuilder.AppendFormat($"{base.DatosCompletos()}, ");
            if (esAlfa)
            {
                stringBuilder.AppendFormat($"alfa de la manada, ");
            }
            stringBuilder.AppendFormat($"edad {(int)this}");

            return stringBuilder.ToString();


        }


        #region Operadores 

        /// <summary>
        /// Dos Perros serán iguales si comparten nombre, raza y edad
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Perro j1, Perro j2)
        {
            return (j1.Nombre == j2.Nombre &&
                   j1.Raza == j2.Raza &&
                   j1.Edad == j2.Edad);

        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        /// <summary>
        ///  Conversión explicita de Perro a entero, retornando su edad.
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator int(Perro p) 
        {
            return p.Edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Perro)  //si el objeto es perro 
            {
                retorno = (Perro)obj == this; // casteamos el objeto para que sea de tipo perro y lo comparamos con el perro donde se está llamando
            }
            return retorno;
        }


        #endregion

    }//fin class perro
}
