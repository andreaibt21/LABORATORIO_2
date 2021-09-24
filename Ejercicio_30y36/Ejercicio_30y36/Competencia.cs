using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30y36
{
    public class Competencia
    {


        private short cantidadCompetidores;
        private short candidadVueltas;
        private List<AutoF1> competidores;

         
         public Competencia()
        {
            this.competidores = new List<AutoF1>(); //inicializa la lista de competidores 
         }

        public Competencia(short cantidadCompetidores, short candidadVueltas): this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.candidadVueltas = candidadVueltas;
        }

        /// <summary>
        /// Generamos las sobrecarga de operadores para agregar, quitar competidores y de comparacion

        /// </summary>
        /// <returns></returns>
        public static bool operator ==(Competencia c, AutoF1 a) 
        {
            bool retorno = false;
            if (c.competidores.Count > 0)
            {
                foreach (AutoF1 auto in c.competidores)
                {
                    if (auto == a )
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random numeroRandom = new Random();
            bool retorno = false;
            
            if (c.competidores.Count < c.cantidadCompetidores && c != a)
            {
                a.EnCompetencia = true;
                a.VueltasRestantes = c.candidadVueltas;
                a.CantidadCombustible = (short)numeroRandom.Next(15, 100);
                c.competidores.Add(a);
                retorno = true;
            }
            return retorno;
        }


        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            if( c == a) // si el auto pertenece a la competencia lo elimino
            {
                c.competidores.Remove(a);
                retorno = true;
            }
            return retorno;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad de vueltas en la competencia: " + this.candidadVueltas);
            sb.AppendLine("Cantidad de competidores: " + this.cantidadCompetidores);
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine(auto.MostrarDatos());
                sb.AppendLine(" ----------------------  ");
            }
            return sb.ToString();
        }




    }//fin class Competencia
}
