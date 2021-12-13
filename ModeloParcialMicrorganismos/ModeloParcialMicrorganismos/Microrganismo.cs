using System;
using System.Text;

namespace Entidades
{
    public abstract class Microrganismo
    {
        /*
         Microorganismos:
        ●	El contador será definido en 1 en sus constructores. Esta variable contendrá la cantidad de 
            gente contagiada por esta simulación, siendo alterada cada vez que se llame a
            la propiedad IndiceDeContagios.
       
         */
        public enum EContagiosidad { Baja, Moderada, Alta};
        public enum ETipo { Virus, Bacteria};

        protected long contador;
        private EContagiosidad contagiosidad;
        private string nombre;
        private ETipo tipo;

        public abstract long IndiceDeContagios {  get; }

        public Microrganismo(string nombre)
        {
            this.nombre = nombre;
            this.contador = 1;

          
        }

        public Microrganismo(string nombre, ETipo tipo, EContagiosidad contagiosidad): this(nombre)
        {
            this.tipo = tipo;
            this.contagiosidad = contagiosidad;
        }

        /// <summary>
        /// 	Informe retornará un texto con el siguiente formato: " El TIPO lleva el nombre de NOMBRE
        ///  y tiene una contagiosidad CONTAGIOSIDAD.Su impacto de contagios se calcula en INDICE DE CONTAGIOS.
        /// </summary>
        /// <returns></returns>
        public string Informe()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El {this.tipo} lleva el nombre de {this.nombre} y tiene una contagiosidad {this.contagiosidad}.Su impacto de contagios se calcula en {this.IndiceDeContagios}.");
            return sb.ToString();
        }
    }
}
